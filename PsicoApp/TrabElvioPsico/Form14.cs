using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace TrabElvioPsico
{
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            //criando um documento
            PdfDocument document = new PdfDocument();

            //adicionando uma nova pagina
            PdfPage page = document.AddPage();
            page.Width = XUnit.FromMillimeter(217);
            page.Height = XUnit.FromMillimeter(220);

            //criando um xgraphics para desenhar 
            XGraphics gfx = XGraphics.FromPdfPage(page);

            //printando a imagem
            using (Bitmap bitmap = new Bitmap((int)page.Width.Point, (int)page.Height.Point))
            {
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    graphics.CopyFromScreen(this.Location, Point.Empty, this.ClientSize);
                }

                //cortando
                int cortesup = (int)XUnit.FromMillimeter(10).Point;
                int corteesq = (int)XUnit.FromMillimeter(05).Point;

                Rectangle corteret = new Rectangle(corteesq, cortesup, bitmap.Width - corteesq, bitmap.Height - cortesup);

                Bitmap cortebit = bitmap.Clone(corteret, bitmap.PixelFormat);

                //salvando a imagem temporariamente
                string tempImagePath = Path.GetTempFileName() + ".png";
                cortebit.Save(tempImagePath, ImageFormat.Png);

                XImage image = XImage.FromFile(tempImagePath);

                // construindo a imagem
                gfx.DrawImage(image, 0, 0, page.Width, page.Height);

                //fechando o arquivo temp
                image.Dispose();
                cortebit.Dispose();

                //salvando o arquivo
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Arquivos PDF|*.pdf";
                saveFileDialog.Title = "Salvar PDF";
                saveFileDialog.ShowDialog();

                if (!string.IsNullOrEmpty(saveFileDialog.FileName))
                {
                    document.Save(saveFileDialog.FileName);
                    MessageBox.Show("Relatório salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                gfx.Dispose();

                File.Delete(tempImagePath);
            }


        }

        private void volt_Click(object sender, EventArgs e)
        {
            Form23 form23 = new Form23();
            form23.Show();
            this.Close();
        }
    }
}
