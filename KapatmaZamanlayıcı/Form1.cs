using Microsoft.VisualBasic.Devices;

namespace KapatmaZamanlayıcı
{
    public partial class KapatmaZamanlayiciForm : Form
    {
        /*
        - Program belirtilen zaman aralıklarında istenilen işlevi yapmaktadır.
        - Eğer zamanlayıcı ayarlayıp programı kapatmaya çalışırsanız program bildirim çubuğuna küçülür.
        - Bildirim çubuğuna küçülen programın simgesinin üzerine geldiğinizde zamanlayıcı hakkında bilgileri görebilirsiniz.
        - Simgeye çift tıklayarak programı tekrar normal moda alabilirsiniz.
        - Zamanlayıcıyı iptal ederseniz normal bir şekilde tamamen kapatabilirsiniz.
        - Zamanlayıcı varken bir şekilde programı tamamen kapatsanız bile -Eğer öncesinde PC'yi kendiniz kapatmazsanız- zamanlayıcının süresi dolunca işlevini yerine getirir.
        */

        public KapatmaZamanlayiciForm()
        {
            //Uygulama çalıştığında otomatik çalışacak komutlar.
            InitializeComponent();
            SaatTextBox.Text = "0";
            DakikaTextBox.Text = "0";
            SaniyeTextBox.Text = "0";
        }

        //Program'da zamanlayıcı yoksa kapatır varsa simge durumuna küçültür.
        static private string programDurumu = "Normal";
        static private string bildirimProgramDurumu = "Normal";
        private void exitLabel_Click(object sender, EventArgs e)
        {
            if (programDurumu == "Normal")
                Application.Exit();
            else
            {
                this.Hide();
                bildirimProgramDurumu = "Gizli";
            }
        }

        //Programı simge çubuğundan çift-tıklama ile açar/kapatır.
        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            if (bildirimProgramDurumu == "Gizli")
            {
                this.Show();
                bildirimProgramDurumu = "Normal";
            }
            else
            {
                this.Hide();
                bildirimProgramDurumu = "Gizli";
            }
        }

        //Uygulamayı görev çubuğuna küçültür.
        private void minimizeLabel_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Uygulama hareketini sağlayan kısım.
        private bool mouseDown;
        private Point mouseDurum;
        private void topBarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseDurum = e.Location;
        }

        private void topBarPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - mouseDurum.X) + e.X, (this.Location.Y - mouseDurum.Y) + e.Y);
                this.Update();
            }
        }

        private void topBarPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        //Çeşitli görsel iyileştirmeler.
        private void minimizeLabel_MouseHover(object sender, EventArgs e)
        {
            MinimizeLabel.BackColor = Color.LightGray;
            AnaToolTip.ToolTipTitle = "";
            AnaToolTip.SetToolTip(MinimizeLabel, "Programı Simge Durumuna Küçült");
        }

        private void minimizeLabel_MouseLeave(object sender, EventArgs e)
        {
            MinimizeLabel.BackColor = Color.AliceBlue;
        }

        private void exitLabel_MouseHover(object sender, EventArgs e)
        {
            ExitLabel.BackColor = Color.Red;
            ExitLabel.ForeColor = Color.White;
            if (programDurumu == "Normal")
            {
                AnaToolTip.ToolTipTitle = "";
                AnaToolTip.SetToolTip(ExitLabel, "Programı Kapat");
            }
            else
            {
                AnaToolTip.ToolTipTitle = "";
                AnaToolTip.SetToolTip(ExitLabel, "Programı Küçült");
            }
        }

        private void exitLabel_MouseLeave(object sender, EventArgs e)
        {
            ExitLabel.BackColor = Color.AliceBlue;
            ExitLabel.ForeColor = Color.Black;
        }

        private void kapatLabel1_MouseHover(object sender, EventArgs e)
        {
            KapatLabel.BackColor = Color.Red;
            KapatLabel.ForeColor = Color.White;
            AnaToolTip.ToolTipTitle = "Sistemi Zorla Kapat";
            AnaToolTip.SetToolTip(KapatLabel, "Yan Tarafta Belirlenen Süre Sonunda Sistemi 'ZORLA' Kapatır!");
            Cursor = Cursors.Hand;
        }

        private void kapatLabel1_MouseLeave(object sender, EventArgs e)
        {
            KapatLabel.BackColor = Color.Transparent;
            Cursor = Cursors.Default;
        }

        private void KapatLabel_MouseDown(object sender, EventArgs e)
        {
            KapatLabel.BackColor = Color.DarkRed;
        }
        private void yenidenBaslatLabel1_MouseHover(object sender, EventArgs e)
        {
            YenidenBaslatLabel.BackColor = Color.GreenYellow;
            YenidenBaslatLabel.ForeColor = Color.Black;
            AnaToolTip.ToolTipTitle = "Sistemi Yeniden Başlat";
            AnaToolTip.SetToolTip(YenidenBaslatLabel, "Yan Tarafta Belirlenen Süre Sonunda Sistemi Yeniden Başlatır!");
            Cursor = Cursors.Hand;
        }

        private void yenidenBaslatLabel1_MouseLeave(object sender, EventArgs e)
        {
            YenidenBaslatLabel.BackColor = Color.Transparent;
            YenidenBaslatLabel.ForeColor = Color.White;
            Cursor = Cursors.Default;
        }

        private void YenidenBaslatLabel_MouseDown(object sender, MouseEventArgs e)
        {
            YenidenBaslatLabel.BackColor = Color.LimeGreen;
        }

        private void zamanlayiciIptalLabel2_MouseHover(object sender, EventArgs e)
        {
            ZamanlayiciIptalLabel.BackColor = Color.DeepSkyBlue;
            ZamanlayiciIptalLabel.ForeColor = Color.Black;
            AnaToolTip.ToolTipTitle = "Zamanlayıcıyı Durdur";
            AnaToolTip.SetToolTip(ZamanlayiciIptalLabel, "Aktif Zamanlayıcıyı İptal Eder!");
            Cursor = Cursors.Hand;
        }

        private void zamanlayiciIptalLabel2_MouseLeave(object sender, EventArgs e)
        {
            ZamanlayiciIptalLabel.BackColor = Color.Transparent;
            ZamanlayiciIptalLabel.ForeColor = Color.White;
            Cursor = Cursors.Default;
        }

        private void ZamanlayiciIptalLabel_MouseDown(object sender, MouseEventArgs e)
        {
            ZamanlayiciIptalLabel.BackColor = Color.Cyan;
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            AnaToolTip.ToolTipTitle = "Program Hakkında Bilgilendirmeler";
            AnaToolTip.SetToolTip(UreticiLabel, "-Program Belirlenen Zaman Aralıklarında İstenilen İşlevi Yapmaktadır.\n-Eğer Zamanlayıcı Ayarlayıp Programı Kapatmaya Çalışırsanız Program, Bildirim Çubuğuna Küçülür.\n-Bildirim Çubuğundaki İcon'dan Zamanlayıcının Durumunu Görebilirsiniz.\n-Bildirim Çubuğundaki İcon'dan Çift Tıklayarak Programı Açabilirsiniz.\n-Zamanlayıcıyı İptal Ederseniz Normal Bir Şekilde Uygulamayı Kapatabilirsiniz.\n-Zamanlayıcı Varken Programı Tamamen Kapatsanız Bile Zamanlayıcının Süresi Dolunca İşlevini Yerine Getirir.");
        }

        //Saat değerinin rakamlardan oluşmasını, boş bırakılamamasını ve maximum değerini yöneten komutlar.
        private void saatTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            SaatTextBox.TextChanged += (s, e) =>
            {
                var textbox = s as TextBox;
                int deger;
                if (int.TryParse(SaatTextBox.Text, out deger))
                    if (deger > 24)
                        SaatTextBox.Text = "24";

                if (SaatTextBox.Text == "")
                    SaatTextBox.Text = "0";
            };
        }

        //Dakika değerinin rakamlardan oluşmasını, boş bırakılamamasını ve maximum değerini yöneten komutlar.
        private void dakikaTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            DakikaTextBox.TextChanged += (s, e) =>
            {
                var textbox = s as TextBox;
                int deger;
                if (int.TryParse(DakikaTextBox.Text, out deger))
                    if (deger > 59)
                        DakikaTextBox.Text = "59";

                if (DakikaTextBox.Text == "")
                    DakikaTextBox.Text = "0";
            };
        }

        //Saniye değerinin rakamlardan oluşmasını, boş bırakılamamasını ve maximum değerini yöneten komutlar.
        private void saniyeTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            SaniyeTextBox.TextChanged += (s, e) =>
            {
                var textbox = s as TextBox;
                int deger;
                if (int.TryParse(SaniyeTextBox.Text, out deger))
                    if (deger > 59)
                        SaniyeTextBox.Text = "59";

                if (SaniyeTextBox.Text == "")
                    SaniyeTextBox.Text = "0";
            };
        }

        //Sistemden tarih ve saati çeken Objeyi oluşturan komut.
        private DateTime dt = DateTime.Now;

        //Sistemi kapatan komut. [fork (system32 klasöründeki shutdown uygulaması çalıştırılır.) - exec (shutdown uygulamasına ','den sonraki komutlar atanır.]
        private void kapatLabel1_Click(object sender, EventArgs e)
        {
            int zamanlayici = (int.Parse(SaatTextBox.Text) * 3600) + (int.Parse(DakikaTextBox.Text) * 60) + (int.Parse(SaniyeTextBox.Text));
            System.Diagnostics.Process.Start("shutdown", "-s -f -t " + zamanlayici);
            programDurumu = "Kapatma";
            //Programın bildirim kısmında gözükmesi ve program durumunu bildirim kısmında üzerine gelince görüntülenmesi sağlar.
            string zamanlayiciOlusturulmaTarihi = dt.ToLocalTime().ToString();
            //Programın durumunu ek olarak bildirim baloncuklarıyla gösteren komutlar.
            AnaBildirimIcon.BalloonTipTitle = "Sistem Kapatılıyor!";
            AnaBildirimIcon.BalloonTipText = "Sisteminiz " + zamanlayici + " saniye içerisinde kapanacaktır.\nZamanlayıcı Oluşturulma Zamanı: " + zamanlayiciOlusturulmaTarihi + ZamanlayiciHesaplama().ToString();
            AnaBildirimIcon.ShowBalloonTip(3000);
            //Programın bildirim kısmında gözükmesi ve program durumunu bildirim kısmında üzerine gelince (tıklamadan) görüntülenmesi sağlar.
            AnaBildirimIcon.Text = "Kapatma Planı Oluşturuldu!\nOluşturulma Zamanı: " + zamanlayiciOlusturulmaTarihi + ZamanlayiciHesaplama().ToString();
        }

        //Sistemi yeniden başlatan komut. [fork (system32 klasöründeki shutdown uygulaması çalıştırılır.) - exec (shutdown uygulamasına ','den sonraki komutlar atanır.]
        private void yenidenBaslatLabel1_Click(object sender, EventArgs e)
        {
            int zamanlayici = (int.Parse(SaatTextBox.Text) * 3600) + (int.Parse(DakikaTextBox.Text) * 60) + (int.Parse(SaniyeTextBox.Text));
            System.Diagnostics.Process.Start("shutdown", "-r -t " + zamanlayici);
            programDurumu = "YBaslatma";
            string zamanlayiciOlusturulmaTarihi = dt.ToLocalTime().ToString();
            //Programın durumunu ek olarak bildirim baloncuklarıyla gösteren komutlar.
            AnaBildirimIcon.BalloonTipTitle = "Sistem Yeniden Başlatılıyor!";
            AnaBildirimIcon.BalloonTipText = "Sisteminiz " + zamanlayici + " saniye içerisinde yeniden başlatılacaktır.\nZamanlayıcı Oluşturulma Zamanı: " + zamanlayiciOlusturulmaTarihi + ZamanlayiciHesaplama().ToString();
            AnaBildirimIcon.ShowBalloonTip(3000);
            //Programın bildirim kısmında gözükmesi ve program durumunu bildirim kısmında üzerine gelince (tıklamadan) görüntülenmesi sağlar.
            AnaBildirimIcon.Text = "Yeniden Başlatma Planı Oluşturuldu!\nOluşturulma Zamanı: " + zamanlayiciOlusturulmaTarihi + ZamanlayiciHesaplama().ToString();

        }

        //Sistemdeki kapatma görevini iptal eden komut. [fork (system32 klasöründeki shutdown uygulaması çalıştırılır.) - exec (shutdown uygulamasına ','den sonraki komutlar atanır.]
        private void zamanlayiciIptalLabel2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("shutdown", "-a");
            programDurumu = "Normal";
            //Programın bildirim kısmında gözükmesi ve program durumunu bildirim kısmında üzerine gelince (tıklamadan) görüntülenmesi sağlar.
            AnaBildirimIcon.Text = "Aktif Zamanlayıcı Yok!";
            //Programın durumunu ek olarak bildirim baloncuklarıyla gösteren komutlar.
            AnaBildirimIcon.BalloonTipTitle = "Sistem Kapatması İptal Edildi!";
            AnaBildirimIcon.BalloonTipText = "Sisteminizin aktif kapatma zamanlayıcısı durduruldu.";
            AnaBildirimIcon.ShowBalloonTip(3000);
        }

        //Verilen komutun ne zaman çalışacağının çıktısını veren fonksiyon.
        private string ZamanlayiciHesaplama()
        {
            int eskiSaniye = dt.Second; int eskiDakika = dt.Minute; int eskiSaat = dt.Hour;
            int girilenSaniye = int.Parse(SaniyeTextBox.Text); int girilenDakika = int.Parse(DakikaTextBox.Text); int girilenSaat = int.Parse(SaatTextBox.Text);
            int eklenecekDakika = 0, eklenecekSaat = 0, eklenecekGun = 0, yeniSaniye, yeniDakika, yeniSaat;
            string zamanlayiciCalismaSaati;
            //Saat, Dakika, Saniye değerlerinin gerçekçi olmasını sağlar. (60 saniye yerine 1 dakika ekleme yapar.)
            {
                if ((eskiSaniye + girilenSaniye) > 59)
                {
                    yeniSaniye = (eskiSaniye + girilenSaniye) - 60;
                    eklenecekDakika++;
                }
                else
                    yeniSaniye = eskiSaniye + girilenSaniye;

                if ((eskiDakika + girilenDakika + eklenecekDakika) > 59)
                {
                    yeniDakika = (eskiDakika + girilenDakika + eklenecekDakika) - 60;
                    eklenecekSaat++;
                }
                else
                    yeniDakika = eskiDakika + girilenDakika + eklenecekDakika;

                if ((eskiSaat + girilenSaat + eklenecekSaat) > 23)
                {
                    yeniSaat = (eskiSaat + girilenSaat + eklenecekSaat) - 24;
                    eklenecekGun++;
                }
                else
                    yeniSaat = (eskiSaat + girilenSaat + eklenecekSaat);
            }
            //Fonksiyonun çıktısını verir.
            {
                if (eklenecekGun > 0)
                    zamanlayiciCalismaSaati = "\nZamanlayıcı Tarihi: " + eklenecekGun + " Gün Sonra Saat " + yeniSaat + ":" + yeniDakika + ":" + yeniSaniye;
                else
                    zamanlayiciCalismaSaati = "\nZamanlayıcı Tarihi: " + yeniSaat + ":" + yeniDakika + ":" + yeniSaniye;
            }
            return zamanlayiciCalismaSaati;
        }
    }
}