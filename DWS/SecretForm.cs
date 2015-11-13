using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace DWS_Lite
{
    public partial class SecretForm : Form
    {
        public SecretForm()
        {
            InitializeComponent();
            _graphics = Titres.CreateGraphics();
        }

        readonly Graphics _graphics;
        private const string Titreesss = @"DWS LITE
(c) 2015
WZT (nummer, WZorNET, adguard, DiamondMonday)

TOP SECRET PAGE!

Bom-bom-bom-tra-ly-ly! LAlLALLALAL!";


        private int _symbols;

        private void GraphicsTimer_Tick(object sender, EventArgs e)
        {
            if (_symbols < Titreesss.Length)
            {
                try
                {
                    var symboladd = Titreesss.ToCharArray(0, Titreesss.Length)[_symbols].ToString();
                    Invoke(new MethodInvoker(delegate {
                                                          Titres.Text += symboladd;
                    }));
                    _symbols++;
                }
                catch (Exception)
                {
                    // ignored
                }
            }
            else if (_symbols + 1 == Titreesss.Length)
            {
                Invoke(new MethodInvoker(delegate {
                                                      Titres.BackgroundImageLayout = ImageLayout.Stretch;
                }));
            }
            else
            {
                GraphicsTimer.Enabled = false;
                _graphics.DrawLines(
                    new Pen(
                        Color.Green,
                        5),
                    new[]
                    {
                        new Point(19, 19),
                        new Point(41, 66),
                        new Point(58, 36),
                        new Point(84, 66),
                        new Point(103, 12)
                    });
                _graphics.DrawLines(
                    new Pen(
                        Color.Red,
                        5),
                    new[]
                    {
                        new Point(39, 21),
                        new Point(45, 16),
                        new Point(89, 17),
                        new Point(46, 65),
                        new Point(76, 67),
                        new Point(88, 61)
                    });
                _graphics.DrawLines(
                    new Pen(
                        Color.Blue,
                        5),
                    new[]
                    {
                        new Point(40, 48),
                        new Point(95, 48),
                        new Point(63, 48),
                        new Point(63, 101)
                    });
                new Thread(() =>
                {
                    try
                    {
                        var img = new WebClient().DownloadData("http://i.imgur.com/RyglB5b.jpg");
                        var ms = new MemoryStream(img);
                        var returnImage = Image.FromStream(ms);
                        Thread.Sleep(5000);
                        Invoke(new MethodInvoker(delegate
                        {
                            BackgroundImage = returnImage;
                            BackgroundImageLayout = ImageLayout.Stretch;
                        }));
                    }
                    catch (Exception)
                    {
                        // ignored
                    }
                }).Start();
            }
        }

        private void MouseDownExit(object sender, MouseEventArgs e)
        {
            _graphics.Dispose();
            Close();
        }
    }
}
