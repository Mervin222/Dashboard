using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

public class Round_corner : Panel
{
    public int CornerRadius { get; set; } = 20;
    public Color BorderColor { get; set; } = Color.Gray;
    public int BorderWidth { get; set; } = 5;

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        GraphicsPath path = new GraphicsPath();
        path.AddArc(0, 0, CornerRadius, CornerRadius, 180, 90);
        path.AddArc(Width - CornerRadius, 0, CornerRadius, CornerRadius, 270, 90);
        path.AddArc(Width - CornerRadius, Height - CornerRadius, CornerRadius, CornerRadius, 0, 90);
        path.AddArc(0, Height - CornerRadius, CornerRadius, CornerRadius, 90, 90);
        path.CloseAllFigures();
        this.Region = new Region(path);

        // Draw border
        using (Pen pen = new Pen(BorderColor, BorderWidth))
        {
            e.Graphics.DrawPath(pen, path);
        }
    }
}
