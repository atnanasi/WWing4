using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace Wwing4
{
    public class TabControlEx : TabControl
    {
        // タブの閉じるボタンクリックイベント
        public event EventHandler TabCloseButtonClick;

        private int mouseDownPointX = 0;
        private int mouseDownPointY = 0;
        private Rectangle dragBoxFromMouseDown = Rectangle.Empty;

        public TabControlEx()
        {
            AllowDrop = true;
            ClearDragTarget();
        }

        protected void OnCloseButtonClick(EventArgs e)
        {
            this.SelectedTab.Dispose();
            //this.TabPages.Remove(this.SelectedTab);

            if (this.TabCloseButtonClick != null)
            {
                this.TabCloseButtonClick(this, e);
            }
            if (this.TabCount == 0)
            {
                Application.Exit();
            }
        }
        private Rectangle GetTabCloseButtonRect(Point pt)
        {
            Rectangle rect;
            for (int i = 0; i < base.TabCount; i++)
            {
                rect = this.GetTabCloseButtonRect(i);
                if (rect.Contains(pt))
                {
                    return rect;
                }
            }
            return Rectangle.Empty;
        }

        private Rectangle GetTabCloseButtonRect(int index)
        {
            Rectangle rect = this.GetTabRect(index);
            rect.X = rect.Right - 20;
            rect.Y = rect.Top + 2;
            rect.Width = 16;
            rect.Height = 16;

            return rect;
        }

        private void DrawTabCloseButton()
        {
            Graphics g = this.CreateGraphics();
            Rectangle rect = Rectangle.Empty;
            Point pt = this.PointToClient(Cursor.Position);
            for (int i = 0; i < this.TabPages.Count; i++)
            {
                rect = this.GetTabCloseButtonRect(i);
                // 閉じるボタン描画
                ControlPaint.DrawCaptionButton(g, rect, CaptionButton.Close, ButtonState.Flat);
            }
            g = null;
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            switch (m.Msg)
            {
                case 15:
                    this.DrawTabCloseButton();
                    break;
                default:
                    break;
            }
        }

        protected override void OnDragOver(System.Windows.Forms.DragEventArgs e)
        {
            base.OnDragOver(e);

            Point pt = new Point(e.X, e.Y);
            //We need client coordinates.
            pt = PointToClient(pt);

            //Get the tab we are hovering over.
            WebTabPage hover_tab = (WebTabPage)GetTabPageByTab(pt);

            //Make sure we are on a tab.
            if (hover_tab != null)
            {
                //Make sure there is a TabPage being dragged.
                if (e.Data.GetDataPresent(typeof(WebTabPage)))
                {
                    e.Effect = DragDropEffects.Move;
                    WebTabPage drag_tab = (WebTabPage)e.Data.GetData(typeof(WebTabPage));

                    int item_drag_index = FindIndex(drag_tab);
                    int drop_location_index = FindIndex(hover_tab);

                    //Don't do anything if we are hovering over ourself.
                    if (item_drag_index != drop_location_index)
                    {
                        ArrayList pages = new ArrayList();

                        //Put all tab pages into an array.
                        for (int i = 0; i < TabPages.Count; i++)
                        {
                            //Except the one we are dragging.
                            if (i != item_drag_index)
                                pages.Add(TabPages[i]);
                        }

                        //Now put the one we are dragging it at the proper location.
                        pages.Insert(drop_location_index, drag_tab);

                        //Make them all go away for a nanosec.
                        TabPages.Clear();

                        //Add them all back in.
                        TabPages.AddRange((WebTabPage[])pages.ToArray(typeof(WebTabPage)));

                        //Make sure the drag tab is selected.
                        SelectedTab = drag_tab;
                    }
                }
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (dragBoxFromMouseDown != Rectangle.Empty &&
                !dragBoxFromMouseDown.Contains(e.X, e.Y))
            {
                if (this.TabCount <= 1)
                    return;

                Point pt = new Point(mouseDownPointX, mouseDownPointY);
                WebTabPage tp = (WebTabPage)GetTabPageByTab(pt);

                if (tp != null)
                {
                    DoDragDrop(tp, DragDropEffects.All);
                }
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            ClearDragTarget();
            Point pt = new Point(e.X, e.Y);
            Rectangle rect = this.GetTabCloseButtonRect(pt);
            if (rect.Contains(pt))
            {
                this.OnCloseButtonClick(new EventArgs());
                this.Invalidate(rect);
            }
            this.ResumeLayout(false);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            ClearDragTarget();
        }

        private void ClearDragTarget()
        {
            dragBoxFromMouseDown = Rectangle.Empty;
            mouseDownPointX = 0;
            mouseDownPointY = 0;
        }

        private void SetupDragTarget(int x, int y)
        {
            Size dragSize = SystemInformation.DragSize;

            dragBoxFromMouseDown =
                new Rectangle(new Point(x - (dragSize.Width / 2),
                                        y - (dragSize.Height / 2)), dragSize);
            mouseDownPointX = x;
            mouseDownPointY = y;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            ClearDragTarget();

            if (e.Button != MouseButtons.Left || e.Clicks >= 2)
                return;
            this.SuspendLayout();
            SetupDragTarget(e.X, e.Y);
        }

        /// <summary>
        /// Finds the TabPage whose tab is contains the given point.
        /// </summary>
        /// <param name="pt">The point (given in client coordinates) to look for a TabPage.</param>
        /// <returns>The TabPage whose tab is at the given point (null if there isn't one).</returns>
        private TabPage GetTabPageByTab(Point pt)
        {
            WebTabPage tp = null;

            for (int i = 0; i < TabPages.Count; i++)
            {
                if (GetTabRect(i).Contains(pt))
                {
                    tp = (WebTabPage)TabPages[i];
                    break;
                }
            }

            return tp;
        }

        /// <summary>
        /// Loops over all the TabPages to find the index of the given TabPage.
        /// </summary>
        /// <param name="page">The TabPage we want the index for.</param>
        /// <returns>The index of the given TabPage(-1 if it isn't found.)</returns>
        private int FindIndex(WebTabPage page)
        {
            for (int i = 0; i < TabPages.Count; i++)
            {
                if (TabPages[i] == page)
                    return i;
            }

            return -1;
        }

        private void InitializeComponent()
        {
        }
    }
}