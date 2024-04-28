using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ilk_win_forms_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
             

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Form Açılıyor..."); //form açılırken mesaj kutusu gönderir.
            comboBox1.Items.Add("Pazartesi"); //Combobox'a veri eklerken form üzerine çift tıkalyıp veriyi elle eklemek en iyisidir.
            comboBox1.Items.Add("Salı");
            comboBox1.Items.Add("Çarşamba");
            comboBox1.Items.Add("Perşembe");
            comboBox1.Items.Add("Cuma");
            comboBox1.Items.Add("Cumartesi");
            comboBox1.Items.Add("Pazar");
            
        }

        private void messagebox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("mesaj kısmı burası","başlık kısmı burası"); //ilk yazılan mesaj içeriği 2. yazılan başlık olur. 3. bir şey yazılmadığı için sadece tamam butonu çıkar.
        }

        private void messagebox2_Click(object sender, EventArgs e)
        {
            
         //MessageBox'da YesNoCancel vb. işlem yapabilmek için DialogResult kullanırız. DialogResult yazılır result değişken gibi = ile tanımlanır ardından message boxı oluşturabiliriz. 
            
            DialogResult result = MessageBox.Show("mesaj kısmı", "Başlık kısmı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);//1.Mesaj,2.Başlık,3.Butonları,4.İconSeçimi   
            if (result == DialogResult.Yes) // Yes butonuna basarsa...
            {
                MessageBox.Show("Yes'e Bastın!");
            }
            else if (result == DialogResult.No) // No butonuna basarlarsa...
            {
                MessageBox.Show("No'ya Bastın!");
            }
            else //Cancel kaldı zaten istersen else if(result == DialogResult.Cancel);{ } şeklinde de yazabilirdik.
            {
                MessageBox.Show("Cancel'a Bastın!"); // Sanırım Cancel sağ üstteki X butonu ile aynı görevi görüyor cancela görev verirsen x'e basıncada aynı görev gerçekleşiyor.
            }
            
        }

        private void textButton_Click(object sender, EventArgs e)
        {
            textButton.Text = "Click"; //tIKLAYINCA tEXT DEĞİŞSİN. 
            textButton.BackColor = SystemColors.Control; //click kullanınca sistem klasik rengi gelsin.   
            label1.Text = "RAMAZAN"; //bu butona basınca label1 labelinin textini RAMAZAN yap.
            label1.BackColor = Color.Green; // Arkaplan rengini yeşil
            label1.ForeColor = SystemColors.ControlText; //ve Yazı rengini sistem varsayılanı yap.
        }

        private void textButton_KeyPress(object sender, KeyPressEventArgs e)
        {
            textButton.Text = "KeyboardClick"; // Klavyeden tuşa basınca bu yazsın butonda...
            textButton.BackColor = Color.Yellow; //keypress kullanınca renk değişsin
            label1.BackColor= Color.Black; //Buton üzerinde keypress kullanınca... label1'in arka plan siyah, yazı rengi beyaz olsun.
            label1.ForeColor = Color.White;
            label1.Text = textButton.Text; //label1'în textini textbutton'un en son halindeki textini alır. 

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Blue; //label 1' e tıklandıgında arka plan rengini ve yazı tipi rengini böyle yap.
            label1.ForeColor = Color.White;
        }

        private void textBoxButton_Click(object sender, EventArgs e)
        {
            label2.Text = textBox1.Text;
        }

        private void baslik_Click(object sender, EventArgs e)
        {
            baslik.Text = "TEXT BOX'A GİRİLEN DEĞERLER HEP STRİNG OLUR"; //Değiştirmek istersek tür dönüşümlerini inceleyip değiştirebilirsin. Convert.to...
              
        }

        private void baslik_DoubleClick(object sender, EventArgs e)
        {
            baslik.Text = "Şimdi *'lı metni yaz";

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) //radioButton1 seçiliyse seçildi yazdır ve diğer butona seçilmedi yazdır.
            {
                radioButton1.Text = "Seçildi";
                radioButton2.Text = "Seçilmedi";
            }
            else                                //seçilmediyse seçilmedi yazdır.
            {
                radioButton1.Text = "Seçilmedi";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked == true)  //aynı durumlar burada da geçerlidir.
            {
                radioButton2.Text = "Seçildi";
                radioButton1.Text = "Seçilmedi";
            }
            else
            {
                radioButton2.Text = "Seçilmedi";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) //Checkbox1 işaretlendiyse ve işaretlenmediyse aşağıdaki textleri yazdır işlemi...
            {
                checkBox1.Text = "İŞARETLENDİ :)";
            }
            else
            {
                checkBox1.Text = "İŞARET KALDIRILDI :(";
            }
        }

        private void comboBoxButton_Click(object sender, EventArgs e) //Combobox'ın altındaki normal buton.
        {
            if (comboBox1.SelectedItem == null) //Eğer comboBox'ta bir item yani gün seçili olmadan butona basılırsa messagebox ile uyarı ver if bloğu. 
            {
                MessageBox.Show("Lütfen gün Seçiniz!","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else //else ise gün seçilmiştir zaten.
            {
                MessageBox.Show(comboBox1.SelectedItem.ToString());  // amacımız comboboxta seçilen itemi butona basınca mesaj kutusu ile bize göstermesi...  
                                                                     //SelectedItem ile gelen veriyi string tabanlı itemler yazdığımız için to TOstring(); ile dönüştürüyoruz.
                /*Bu şekilde de yapabilirdik: 
                 string gun = comboBox1.SelectedItem.ToString();
                 MessageBox.Show(gun);    --> Bu şekilde değişken tanımlayarak yapılabilir. */
            }



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxLabel.Text = comboBox1.SelectedItem.ToString(); //Combobox'ın üzerindeki label'ın textini seçtiğimiz güne yani itemine göre string olarak değiştir.
        }

        private void formButton_Click(object sender, EventArgs e)
        {
            string name = textboxName.Text;
            string surname = textboxSurname.Text;
            string nameSurname = name + surname;
            Form2 yeniForm2 = new Form2(); //Form2'yi burada açmak için bir tane oluşturuyoruz ve buradaki ismi yeniForm2 oluyor.
            yeniForm2.lblnameSurname.Text = nameSurname;//Form2'deki label'ı properties kısmındaki modifiers bölümünden public yapıyoruz Yada Form2.Designer.cs kısmından elle yazabiliriz.
            //public yapmazsak eğer form1 üzerinden yazdığımız için form2 üzerindeki bir nesneye private default olarak geldiği için erişemeyiz. Public yaparaklblnameSurname'ye eriştik.
            yeniForm2.ShowDialog(); //ShowDialog(); ile açılan yeni formdan diğerine yani form1'e işlem yapmadan veya kapatmadan geçemeyiz.
            //yeniForm2.Shot(); yazsaydık eğer 2 form arasında geçiş sağlanabiliyor...
            
        }
    }
}
