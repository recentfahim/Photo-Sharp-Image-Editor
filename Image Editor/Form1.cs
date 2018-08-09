using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace Image_Editor
{
    public partial class ImageEditor : Form
        
    {
        
         Bitmap newBitmap;
         Image image ;
         private Size Multiplier;
       
         float gamma = 0;
         float contrast = 0;
         private Size OriginalImageSize;
         
         int cropX;
         int cropY;
         int cropWidth;

         int cropHeight;
        
         public Pen cropPen;

         public DashStyle cropDashStyle = DashStyle.DashDot;
         public bool Makeselection = false;
         public bool CreateText = false;


         bool boolbright = true,boolcontrast = true , boolgamma = true , boolrotate = true,boolflip = true,boolrbg=true,boolcrop=true;
         bool txtcrp;
         //private Mirror mr;
      
        Alert alert = new Alert();
        public ImageEditor()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


       
        private void CropLevel_Click(object sender, EventArgs e)
        {

        }

       

        
        private void PictureBox1_Click(object sender, EventArgs e)
        {
          
        }
        private void label1_Click(object sender, EventArgs e)
        {
           
            BrightnessTrackBar.Show();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void TrackBar_Scroll(object sender, EventArgs e)
        {
          

                label1.Text = BrightnessTrackBar.Value.ToString();



                float FinalValue = BrightnessTrackBar.Value * 0.01f;

                float[][] FloatColorMatrix = {
                                          
                                          new float [] {1 , 0 , 0 , 0 , 0},
                                          new float [] {0 , 1 , 0 , 0 , 0},
                                          new float [] {0 , 0 , 1 , 0 , 0},
                                          new float [] {0 , 0 , 0 , 1 , 0},
                                          new float [] {FinalValue,FinalValue,FinalValue,1,1},
                                          
                                          };
                ColorMatrix newColorMatrix = new ColorMatrix(FloatColorMatrix);

                ImageAttributes Attributes = new ImageAttributes();

                Attributes.SetColorMatrix(newColorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);


                Image img = image;
                // Image img = newBitmap.
                Graphics NewGraphics = default(Graphics);

                // Bitmap NewBitmap = new Bitmap(Convert.ToInt32(img.Width), Convert.ToInt32(img.Height));

                Bitmap NewBitmap = new Bitmap(Convert.ToInt32(newBitmap.Width), Convert.ToInt32(newBitmap.Height));


                NewGraphics = Graphics.FromImage(NewBitmap);

                NewGraphics.DrawImage(newBitmap, new Rectangle(0, 0, NewBitmap.Width + 1, NewBitmap.Height + 1), 0, 0, NewBitmap.Width + 1, NewBitmap.Height + 1, GraphicsUnit.Pixel, Attributes);
                //  NewGraphics.DrawImage(img, new Rectangle(0, 0, NewBitmap.Width + 1, NewBitmap.Height + 1), 0, 0, NewBitmap.Width + 1, NewBitmap.Height + 1, GraphicsUnit.Pixel, Attributes);

                PictureBox1.Image = NewBitmap;



            
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (PictureBox1.Image == null)
            {
                alert.Show(); 
            }
            else
            {
                
                if (boolbright == true)
                {
                    BrightnessTrackBar.Show();
                    label1.Show();
                    boolbright = false;
                }
                else if(boolbright == false)
                {
                    BrightnessTrackBar.Hide();
                    label1.Hide();
                    boolbright = true;
                }
                
               
            }
        }

      
         
       private void button2_Click(object sender, EventArgs e)
       {
         

       }

       
        private void Browsebutton_Click(object sender, EventArgs e)
       {
           if (openFileDialog4.ShowDialog() == DialogResult.OK)
           {

               PictureBox1.Image = System.Drawing.Image.FromFile(openFileDialog4.FileName);
               newBitmap = new Bitmap(openFileDialog4.FileName);
           }
       }

       private void button4_Click(object sender, EventArgs e)
       {
            if (PictureBox1.Image == null)
           {
               alert.Show(); 
           }
           else
            {
                if (boolrotate == true)
              
                {
                    RotateLeftButton.Show();
                    RotateRightButton.Show();


                    boolrotate = false;
               }
                else if (boolrotate == false) 
               {  
                   RotateRightButton.Hide();
                   RotateLeftButton.Hide();

                   boolrotate = true;
                
               }
            }
           
       }

       private void Rotate_Click(object sender, EventArgs e)
       {
            Bitmap bmp = new Bitmap(newBitmap.Width, newBitmap.Height);
            newBitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
            PictureBox1.Image = newBitmap;
            PictureBox1.Refresh();

           
       }

       private void button6_Click(object sender, EventArgs e)
       {

            Bitmap bmp = new Bitmap(newBitmap.Width,newBitmap.Height);
            newBitmap.RotateFlip(RotateFlipType.Rotate270FlipNone);
            PictureBox1.Image = newBitmap;
            PictureBox1.Refresh();
           
       }

       private void button7_Click(object sender, EventArgs e)
       {
           Bitmap bmp = new Bitmap(newBitmap.Width, newBitmap.Height);
           newBitmap.RotateFlip(RotateFlipType.RotateNoneFlipX);
           PictureBox1.Image = newBitmap;
           PictureBox1.Refresh();
           
       }
       private void button8_Click(object sender, EventArgs e)
       {
           Bitmap bmp = new Bitmap(newBitmap.Width, newBitmap.Height);
           newBitmap.RotateFlip(RotateFlipType.RotateNoneFlipY);
           PictureBox1.Image = newBitmap;
           PictureBox1.Refresh();
           
       }

       private void openToolStripMenuItem_Click(object sender, EventArgs e)
       {
           browsemethod();
       }

       private void saveToolStripMenuItem_Click(object sender, EventArgs e)
       {
           saveMethod();
       }

       private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
       {
          
       }

       private void exitToolStripMenuItem_Click(object sender, EventArgs e)
       {
           Application.Exit();
       }      

       private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
       {
          
           AboutBox1 ab = new AboutBox1();
           ab.Show();
       }

       private void button9_Click(object sender, EventArgs e)
       {
           if (PictureBox1.Image == null)
           {
               alert.Show(); 
           }
           else
           {
               Bitmap Newbitmap = new Bitmap(PictureBox1.Image);
               for (int i = 0; i < Newbitmap.Width; i++)
               {
                   for (int j = 0; j < Newbitmap.Height; j++)
                   {

                       Color maincolor = Newbitmap.GetPixel(i, j);

                       int grayscale = (int)((maincolor.R * .3) + (maincolor.G * .59) + (maincolor.B * .11));

                       //  Color newcolor = Color.FromArgb(grayscale,grayscale,grayscale ;

                       Newbitmap.SetPixel(i, j, Color.FromArgb(grayscale, grayscale, grayscale));
                   }
               }

               PictureBox1.Image = Newbitmap;

           }

          
       }


       private void button1_Click(object sender, EventArgs e)
       {
           if (PictureBox1.Image == null)
           {
               alert.Show(); 
           }
           else
           {
               if (boolflip == true)
               {
                   RotateHorizantalButton.Show();
               
                   RotateVerticalButton.Show();

                   boolflip = false;
               }
               else if (boolflip == false) 
               {
                  RotateHorizantalButton.Hide();
                   RotateVerticalButton.Hide();
                   boolflip = true;
               }
               
           }
       }

       private void Browsebutton_Click_1(object sender, EventArgs e)
       {
           Browsebutton.ForeColor.ToArgb();
           count = 0; 
           browsemethod();
       }
       private void browsemethod() {

           OpenFileDialog ofd = new OpenFileDialog();
           ofd.Filter = "JPEG Files|*.jpg" +            
               "|Enhanced Windows MetaFile|*.emf" +
               "|Exchangeable Image File|*.exif" +             
               "|Gif Files|*.gif|Bitmap Files|*.bmp" +
               "|PNG Files|*.png|TIFF Files|*.tif|Windows MetaFile|*.wmf";
           ofd.DefaultExt = "jpg";
           
           ofd.FilterIndex = 1;
           if (ofd.ShowDialog() == DialogResult.OK)
           {
               image = PictureBox1.Image = System.Drawing.Image.FromFile(ofd.FileName);
               //Image im1 = Image.FromFile(openFileDialog4.FileName);
               newBitmap = new Bitmap(ofd.FileName);
              
           }


       

       
       }
       
       private void saveMethod() {

           saveFileDialog1.Filter = "Jpeg Images(*.jpg)|*.jpg|Png Images(*.png)|*.png";

           saveFileDialog1.Filter += "|Bitmap Images(*.bmp)|*.bmp";

           if (PictureBox1.Image == null)
           {
               alert.Show(); 
           }
           else
           {
               if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
               {
                   if (check == true)
                   {
                       pictureBox2.Image.Save(saveFileDialog1.FileName, ImageFormat.Jpeg);
                   }
                   else
                   {
                       PictureBox1.Image.Save(saveFileDialog1.FileName, ImageFormat.Jpeg);
                   }
               }
           }

       }


       private void SaveButton_Click(object sender, EventArgs e)
       {
           saveMethod();
          
       }



       private void CropButton_Click(object sender, EventArgs e)
       {
           if (PictureBox1.Image == null)
           {
               alert.Show();

           }
           else
           {
               if (boolcrop == true)
               {
                   SelectImageButton.Show();
                   CropImageButton.Show();
                   boolcrop = false;
               }
               else if (boolcrop == false)
               {
                   SelectImageButton.Hide();
                   CropImageButton.Hide();
                   boolcrop = true;
               }
           }
       }

       private void SelectImageButton_Click(object sender, EventArgs e)
       {
           txtcrp = false;
           Makeselection = true;
           CropImageButton.Enabled = true;
       }
       private void PictureBoxLocation()
       {
           int _x = 0;
           int _y = 0;
           if (splitContainer1.Panel1.Width > PictureBox1.Width)
           {
               _x = (splitContainer1.Panel1.Width - PictureBox1.Width) / 2;
           }
           if (splitContainer1.Panel1.Height > PictureBox1.Height)
           {
               _y = (splitContainer1.Panel1.Height - PictureBox1.Height) / 2;
           }
           PictureBox1.Location = new Point(_x, _y);
       }
       private void SplitContainer1_Panel1_Resize(object sender, EventArgs e)
       {
           PictureBoxLocation();
       }

       private void CropImageButton_Click(object sender, EventArgs e)
       {
           Makeselection = false;
           Cursor = Cursors.Default;

           try
           {
               if (cropWidth < 1)
               {
                   return;
               }
               Rectangle rect = new Rectangle(cropX, cropY, cropWidth, cropHeight);
               
               Bitmap OriginalImage = new Bitmap(PictureBox1.Image, PictureBox1.Width, PictureBox1.Height);
               //Original image
               Bitmap _img = new Bitmap(cropWidth, cropHeight);
               // for cropinf image
               Graphics g = Graphics.FromImage(_img);
               // create graphics
               g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
               g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
               g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
               //set image attributes
               g.DrawImage(OriginalImage, 0, 0, rect, GraphicsUnit.Pixel);

               PictureBox1.Image = _img;
               PictureBox1.Width = _img.Width;
               PictureBox1.Height = _img.Height;
               PictureBoxLocation();
               CropImageButton.Enabled = false;
              // PictureBox1.Size = new Size(827, 598);
           }
           catch (Exception ex)
           {
               MessageBox.Show("Error : "+ex);
           }
       }
       int count=0;
    
       private void button10_Click(object sender, EventArgs e)
       {
           if (count < 5)
           {
               count++;
               if (PictureBox1.Image == null)
               {
                   alert.Show();
               }
               else
               {

                   Multiplier = new Size(2, 2);
                   Image Myimage = PictureBox1.Image;
                   Bitmap Mybitmap = new Bitmap(Myimage, Convert.ToInt32(Myimage.Width / Multiplier.Width), Convert.ToInt32(Myimage.Height / Multiplier.Height));
                   Graphics grafic = Graphics.FromImage(Mybitmap);

                   PictureBox1.Image = Mybitmap;
                   

               }
           }
          
        

       }

       private void button2_Click_1(object sender, EventArgs e)
       {
           if (PictureBox1.Image == null)
           {
               alert.Show();
           }
           else
           {
               textBox1.Size = new Size(172,20);
               textBox1.Text = null;
               count = 0;
               PictureBox1.Size = new Size(827, 598);
               PictureBox1.Location = new Point(0, 0);
               OriginalPicLabel.Hide();
               BlueEffectlabel.Hide();
               RedEffectlabel.Hide();
               GreenEffectlabel.Hide();
               panel1.Size = new Size(856, 598);
               MirrorLabel.Hide();
               pictureBox2.Hide();
               PictureBox1.Image = image;
               check = false;
           }
       }

       private void InvertButton_Click(object sender, EventArgs e)
       {
           if (PictureBox1.Image == null)
           {
               alert.Show(); 
           }
           else
           {
               Bitmap bmp = new Bitmap(PictureBox1.Image);

               for (int i = 0; i < bmp.Width; i++)
               {
                   for (int j = 0; j < bmp.Height; j++)
                   {
                       Color pixel = bmp.GetPixel(i, j);
                       int red = pixel.R;
                       int green = pixel.G;
                       int blue = pixel.B;

                       bmp.SetPixel(i, j, Color.FromArgb(255 - red, 255 - green, 255 - blue));
                   }
               }
               PictureBox1.Image = bmp;

           }
       }

      

       private void helpToolStripMenuItem_Click(object sender, EventArgs e)
       {
           
           MessageBox.Show("No help available at this moment!!!");
       }

       private void saveAsToolStripMenuItem_Click_1(object sender, EventArgs e)
       {

       }

       private void GammaButton_Click(object sender, EventArgs e)
       {
           if (PictureBox1.Image == null)
           {
               alert.Show(); 
           }

           else
           {
               if (boolgamma == true)
               {
                   GammaLabel.Show();

                   GammaTrackBar.Show();
                   boolgamma = false;
               }
               else if (boolgamma == false)
               {
                   GammaLabel.Hide();
                   GammaTrackBar.Hide();
                   boolgamma = true;
               }
           }

       }

       private void GammaTrackBar_Scroll(object sender, EventArgs e)
       {
          
           GammaLabel.Text = GammaTrackBar.Value.ToString();

           gamma = 0.04f * GammaTrackBar.Value;

           Bitmap NewBitmap = new Bitmap(newBitmap.Width, newBitmap.Height);

           Graphics g = Graphics.FromImage(NewBitmap);
           ImageAttributes ia = new ImageAttributes();

           ia.SetGamma(gamma);
           g.DrawImage(newBitmap , new Rectangle( 0 ,0 , newBitmap.Width , newBitmap.Height)  , 0 , 0 ,newBitmap.Width, newBitmap.Height,GraphicsUnit.Pixel , ia);

           g.Dispose();
           ia.Dispose();

           PictureBox1.Image = NewBitmap;


           
       }

       private void ContrastTrackBar_Scroll(object sender, EventArgs e)
       {
          
               ContrastLabel.Text = ContrastTrackBar.Value.ToString();

               contrast = 0.04f * ContrastTrackBar.Value;
               Bitmap bmp = new Bitmap(newBitmap.Width, newBitmap.Height);

               Graphics g = Graphics.FromImage(bmp);

               ImageAttributes ia = new ImageAttributes();

               float[][] FloatColorMatrix = {
                                          
                                          new float [] {contrast , 0f , 0f , 0f , 0f},
                                          new float [] {0f , contrast , 0f , 0f , 0f},
                                          new float [] {0f , 0f , contrast , 0f , 0f},
                                          new float [] {0f , 0f , 0f , 1f , 0f},
                                          new float [] {0.001f,0.001f,0.001f,0f,1f}
                                             };

               ColorMatrix newColorMatrix = new ColorMatrix(FloatColorMatrix);
               ia.SetColorMatrix(newColorMatrix);

               g.DrawImage(newBitmap, new Rectangle(0, 0, newBitmap.Width, newBitmap.Height), 0, 0, newBitmap.Width, newBitmap.Height, GraphicsUnit.Pixel, ia);
               g.Dispose();
               ia.Dispose();
               PictureBox1.Image = bmp;
           
       }

       private void Contrast_Click(object sender, EventArgs e)
       {
           if (PictureBox1.Image == null)
           {
               alert.Show(); 
           }

           else
           {
               if (boolcontrast == true)
               {
                   ContrastLabel.Show();
               
                   ContrastTrackBar.Show();
                   boolcontrast = false;
               }
               else if (boolcontrast == false) 
               {
                   ContrastTrackBar.Hide();
                   ContrastLabel.Hide();
                   boolcontrast = true;
               }
           }
       }

      
       private void fileToolStripMenuItem_Click(object sender, EventArgs e)
       {

       }

       private void ContrastLabel_Click(object sender, EventArgs e)
       {

       }

       private void label1_Click_1(object sender, EventArgs e)
       {

       }


       bool check = false;
       private void MirrorButton_Click(object sender, EventArgs e)
       {
           if (PictureBox1.Image == null)
           {
               alert.Show(); 
           }

           else
           {
           RedEffectlabel.Hide();
           BlueEffectlabel.Hide();
           GreenEffectlabel.Hide();
           MirrorLabel.Show();
           check = true;
           if (PictureBox1.Image == null)
           {
               alert.Show();
           }
           else
           {
               MirrorLabel.Visible = true;
               OriginalPicLabel.Visible = true;
               panel1.Size = new Size(400, 300);
               PictureBox1.Size = new Size(400, 300);
               pictureBox2.Visible = true;

               Bitmap bmp = new Bitmap(PictureBox1.Image);

               int width = bmp.Width;
               int height = bmp.Height;

               Bitmap btmp = new Bitmap(width * 2, height);

               for (int y = 0; y < height; y++)
               {
                   for (int lx = 0, rx = width * 2 - 1; lx < width; lx++, rx--)
                   {
                       Color p = bmp.GetPixel(lx, y);

                       btmp.SetPixel(lx, y, p);
                       btmp.SetPixel(rx, y, p);


                   }


               }
               pictureBox2.Size = new Size(800, 300);
               pictureBox2.Image = btmp;
           }
           }
       }

       private void RedBlueGreen_Click(object sender, EventArgs e)
       {
           if (PictureBox1.Image == null)
           {
               alert.Show(); 
           }
           else
           {
                 
                if (boolrbg == true)
                {
                    RedButton.Show();
             
                    BlueButton.Show();
              
                    GreenButton.Show();
                   
                    boolrbg = false;
                }
                else if (boolrbg == false)
                {
                    RedButton.Hide();

                    BlueButton.Hide();

                    GreenButton.Hide();
                    boolrbg = true;
                }
           }
       }

       private void RedButton_Click(object sender, EventArgs e)
       {
           OriginalPicLabel.Show();
           BlueEffectlabel.Hide();
           GreenEffectlabel.Hide();
           MirrorLabel.Hide();
           check = true;
           RedEffectlabel.Show();
           Bitmap bmp = new Bitmap(PictureBox1.Image);
           pictureBox2.Visible = true;
           panel1.Size = new Size(400, 300);
           PictureBox1.Size = new Size(408, 300);
           pictureBox2.Size = new Size(400, 300);
           int height = bmp.Height;
           int width = bmp.Width;

           Bitmap rbmp = new Bitmap(bmp);
           
           for (int y = 0; y < height; y++)
           {
               for (int x = 0; x < width; x++)
               {
                   Color p = bmp.GetPixel(x, y);


                   int a = p.A;
                   int r = p.R;
                  

                   rbmp.SetPixel(x, y, Color.FromArgb(a, r, 0, 0));
                   

               }
           }

           PictureBox1.Image = image;
           pictureBox2.Image = rbmp;
       }

       private void BlueButton_Click(object sender, EventArgs e)
       {
           if (PictureBox1.Image == null) { }
           GreenEffectlabel.Hide();
           RedEffectlabel.Hide();
           OriginalPicLabel.Show();
           MirrorLabel.Hide();
           BlueEffectlabel.Show();
           check = true;

           Bitmap bmp = new Bitmap(PictureBox1.Image);
           pictureBox2.Visible = true;
           panel1.Size = new Size(400, 300);
           PictureBox1.Size = new Size(400, 300);
           pictureBox2.Size = new Size(400, 300);
           int height = bmp.Height;
           int width = bmp.Width;

           Bitmap bbmp = new Bitmap(bmp);
         

           for (int y = 0; y < height; y++)
           {
               for (int x = 0; x < width; x++)
               {
                   Color p = bmp.GetPixel(x, y);


                   int a = p.A;
                   int b = p.B;

                   bbmp.SetPixel(x, y, Color.FromArgb(a, 0, 0, b));

               }
           }

           PictureBox1.Image = image;
           pictureBox2.Image = bbmp;
       }

       private void GreenButton_Click(object sender, EventArgs e)
       {
           BlueEffectlabel.Hide();
           MirrorLabel.Hide();
           RedEffectlabel.Hide();
           OriginalPicLabel.Show();
           GreenEffectlabel.Show();
           check = true;
           Bitmap bmp = new Bitmap(PictureBox1.Image);
           pictureBox2.Visible = true;
           panel1.Size = new Size(400, 300);

           PictureBox1.Size = new Size(400, 300);
           pictureBox2.Size = new Size(400, 300);
           int height = bmp.Height;
           int width = bmp.Width;

          
           Bitmap gbmp = new Bitmap(bmp);

           for (int y = 0; y < height; y++)
           {
               for (int x = 0; x < width; x++)
               {
                   Color p = bmp.GetPixel(x, y);


                   int a = p.A;
                 
                   int g = p.G;
                  

                  
                   gbmp.SetPixel(x, y, Color.FromArgb(a, 0, g, 0));
                  

               }
           }

           PictureBox1.Image = image;
           pictureBox2.Image = gbmp;
       }

       private void GreenEffectlabel_Click(object sender, EventArgs e)
       {

       }

       

       private void MirrorLabel_Click(object sender, EventArgs e)
       {

       }
       private bool text = false;
       private void CreateTextButton_Click(object sender, EventArgs e)
       {
          
       }
       //private void PictureBox1_MouseDown(object sen)
      // Brush myBrush = new SolidBrush(Color myColor));
       Font myFontf;
       Color myColor;
       private void TextButton_Click(object sender, EventArgs e)
       {
           if (PictureBox1.Image == null)
           {
               alert.Show(); 
           }
           else
           {
               txtcrp = true;
             //  TextButton.Enabled = false;
           }
       }
       
       private void FontButton_Click(object sender, EventArgs e)
       {
           if (PictureBox1.Image == null)
           {
               alert.Show();
           }
           else
           {
              // TextButton.Show();
               fontDialog1.ShowColor = true;
               fontDialog1.Font = textBox1.Font;
               fontDialog1.Color = textBox1.ForeColor;

               if (fontDialog1.ShowDialog() != DialogResult.Cancel)
               {

                   myFontf = fontDialog1.Font;
                   myColor = fontDialog1.Color;
                   textBox1.Font = fontDialog1.Font;
                   textBox1.ForeColor = myColor;
               }
           }
       }

       private void ZoomInButton_Click(object sender, EventArgs e)
       {
           if (PictureBox1.Image == null)
           {
               alert.Show();
           }

           else
           {
               //   PictureBox1.Height += 10;
               // PictureBox1.Width += 10;

               PictureBox1.Top = (int)(PictureBox1.Top - (PictureBox1.Height * 0.025));
               PictureBox1.Left = (int)(PictureBox1.Left - (PictureBox1.Width * 0.025));
               PictureBox1.Height = (int)(PictureBox1.Height + (PictureBox1.Height * 0.05));
               PictureBox1.Width = (int)(PictureBox1.Width + (PictureBox1.Width * 0.05));
           }
       }

       private void Blur_Click(object sender, EventArgs e)
       {
           if (PictureBox1.Image == null)
           {
               alert.Show(); 
           }
           else
           {

               PictureBox1.Size = new Size(826, 598);
               Multiplier = new Size(2, 2);
               Image Myimage = PictureBox1.Image;
               Bitmap Mybitmap = new Bitmap(Myimage, Convert.ToInt32(Myimage.Width / Multiplier.Width), Convert.ToInt32(Myimage.Height / Multiplier.Height));
               Graphics grafic = Graphics.FromImage(Mybitmap);

               PictureBox1.Image = Mybitmap;
           }
       }

       private void ZoomOutButton_Click_1(object sender, EventArgs e)
       {
           if (PictureBox1.Image == null)
           {
               alert.Show(); 
           }
           else
           {
               PictureBox1.Height -= 10;
               PictureBox1.Width -= 10;
               ////  PictureBox1.Location = new 
               PictureBox1.Top = (int)(PictureBox1.Top + (PictureBox1.Height * 0.025));
               PictureBox1.Left = (int)(PictureBox1.Left + (PictureBox1.Width * 0.025));
               PictureBox1.Height = (int)(PictureBox1.Height - (PictureBox1.Height * 0.05));
               PictureBox1.Width = (int)(PictureBox1.Width - (PictureBox1.Width * 0.05));
           }
       }

       private void textBox1_TextChanged(object sender, EventArgs e)
       {

       }

       private void PictureBox1_MouseMove_1(object sender, MouseEventArgs e)
       {
           if (txtcrp == true)
           {
               Brush brush = new SolidBrush(myColor);
               using (Graphics g = Graphics.FromHwnd(PictureBox1.Handle))
               {
                   using (myFontf)
                   {
                       g.DrawString(textBox1.Text, myFontf,brush , new PointF(e.X, e.Y));
                   }
               }
               txtcrp = true;
           }
           else if (txtcrp == false)
           {
           

               Cursor = Cursors.Default;
               if (Makeselection)
               {

                   try
                   {
                       if (PictureBox1.Image == null)
                           return;


                       if (e.Button == System.Windows.Forms.MouseButtons.Left)
                       {
                           PictureBox1.Refresh();
                           cropWidth = e.X - cropX;
                           cropHeight = e.Y - cropY;
                           PictureBox1.CreateGraphics().DrawRectangle(cropPen, cropX, cropY, cropWidth, cropHeight);
                       }



                   }
                   catch (Exception ex)
                   {
                       MessageBox.Show("Error : " + ex);
                   }
               }
               txtcrp = false;
           }
       }
    

       private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
       {
           try
           {
               if (txtcrp == true)
               {
                   Brush brush = new SolidBrush(myColor);
                   using (Graphics g = Graphics.FromHwnd(PictureBox1.Handle))
                   {
                       using (myFontf)
                       {
                           g.DrawString(textBox1.Text, myFontf, brush, new PointF(e.X, e.Y));
                       }
                   }
                   txtcrp = true;
               }


               else if (txtcrp == false)
               {

                   Cursor = Cursors.Default;
                   if (Makeselection)
                   {

                       try
                       {
                           if (e.Button == System.Windows.Forms.MouseButtons.Left)
                           {
                               Cursor = Cursors.Cross;
                               cropX = e.X;
                               cropY = e.Y;

                               cropPen = new Pen(Color.Black, 1);
                               cropPen.DashStyle = DashStyle.DashDotDot;


                           }
                           PictureBox1.Refresh();
                       }
                       catch (Exception ex)
                       {
                           MessageBox.Show("Error " + ex);
                       }
                   }
                   txtcrp = false;
               }
           }
           catch (Exception ex) { }
       }


       private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
       {
           if (txtcrp == true)
           {
               Brush brush = new SolidBrush(myColor);
               using (Graphics g = Graphics.FromHwnd(PictureBox1.Handle))
               {
                   using (myFontf)
                   {
                       g.DrawString(textBox1.Text, myFontf, brush, new PointF(e.X, e.Y));
                   }
               }
               txtcrp = true;
           }
           else if (txtcrp == false)
           {
                if (Makeselection)
                {
                    Cursor = Cursors.Default;
                }
                txtcrp = false;
            }
       }

       private void ImageEditor_Click(object sender, EventArgs e)
       {

       }

       private void PictureBox1_MouseHover(object sender, EventArgs e)
       {

       }

       private void Browsebutton_MouseMove(object sender, MouseEventArgs e)
       {
       }

       private void Browsebutton_MouseHover(object sender, EventArgs e)
       {
          
       }

       private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
       {
           Brush brush = new SolidBrush(myColor);
           using (Graphics g = Graphics.FromHwnd(PictureBox1.Handle))
           {
               using (myFontf)
               {
                   g.DrawString(textBox1.Text, myFontf, brush, new PointF(e.X, e.Y));
               }
           }
       }

       

       
    
       
    }
}
