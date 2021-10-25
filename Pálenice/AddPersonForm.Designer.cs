
namespace Pálenice
{
    partial class AddPersonForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OKButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BirthNumTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CitytextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PostalCodeTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.StreetTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DescriptiveNumberTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Location = new System.Drawing.Point(49, 204);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(146, 36);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rodné číslo";
            // 
            // BirthNumTextBox
            // 
            this.BirthNumTextBox.Location = new System.Drawing.Point(12, 39);
            this.BirthNumTextBox.Name = "BirthNumTextBox";
            this.BirthNumTextBox.Size = new System.Drawing.Size(122, 27);
            this.BirthNumTextBox.TabIndex = 3;
            this.BirthNumTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveBetweenTextBoxes);
            // 
            // NameTextBox
            // 
            this.NameTextBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Adéla",
            "Adam",
            "Adriana",
            "Adrian",
            "Agáta",
            "Albert",
            "Alena",
            "Aleš",
            "Alexandra",
            "Alex",
            "Alice",
            "Alexander",
            "Alžběta",
            "Alexandr",
            "Amálie",
            "Andrej",
            "Amélie",
            "Antonín",
            "Andrea",
            "Benjamin",
            "Aneta",
            "Dalibor",
            "Anežka",
            "Damián",
            "Anna",
            "Dan",
            "Bára",
            "Daniel",
            "Barbora",
            "David",
            "Beáta",
            "Denis",
            "Daniela",
            "Dominik",
            "Denisa",
            "Eduard",
            "Diana",
            "Eliáš",
            "Dominika",
            "Erik",
            "Dorota",
            "Filip",
            "Ela",
            "František",
            "Elen",
            "Gabriel",
            "Elena",
            "Hugo",
            "Eliška",
            "Hynek",
            "Ella",
            "Ivan",
            "Ellen",
            "Jáchym",
            "Ema",
            "Jakub",
            "Emma",
            "Jan",
            "Ester",
            "Jaromír",
            "Eva",
            "Jaroslav",
            "Gabriela",
            "Jindřich",
            "Hana",
            "Jiří",
            "Helena",
            "Jonáš",
            "Izabela",
            "Josef",
            "Jana",
            "Kamil",
            "Johana",
            "Karel",
            "Jolana",
            "Kevin",
            "Josefína",
            "Kristian",
            "Julie",
            "Kristián",
            "Justýna",
            "Kryštof",
            "Kamila",
            "Ladislav",
            "Karolína",
            "Libor",
            "Kateřina",
            "Luboš",
            "Klára",
            "Lukáš",
            "Klaudie",
            "Marek",
            "Kristina",
            "Martin",
            "Kristýna",
            "Matěj",
            "Laura",
            "Matouš",
            "Lea",
            "Matyas",
            "Lenka",
            "Matyáš",
            "Leona",
            "Max",
            "Leontýna",
            "Maxim",
            "Liliana",
            "Maxmilián",
            "Linda",
            "Michael",
            "Lucie",
            "Michal",
            "Magdalena",
            "Mikuláš",
            "Magdaléna",
            "Milan",
            "Mariana",
            "Miroslav",
            "Marie",
            "Nicolas",
            "Markéta",
            "Nikolas",
            "Martina",
            "Oldřich",
            "Mia",
            "Oliver",
            "Michaela",
            "Ondřej",
            "Monika",
            "Oskar",
            "Natálie",
            "Patrik",
            "Nela",
            "Pavel",
            "Nella",
            "Petr",
            "Nelly",
            "Prokop",
            "Nicol",
            "Radek",
            "Nikol",
            "Radim",
            "Nikola",
            "René",
            "Nina",
            "Richard",
            "Patricie",
            "Robert",
            "Pavla",
            "Robin",
            "Pavlína",
            "Roman",
            "Petra",
            "Rostislav",
            "Rozálie",
            "Rudolf",
            "Sabina",
            "Samuel",
            "Sandra",
            "Sebastian",
            "Sára",
            "Sebastián",
            "Simona",
            "Stanislav",
            "Sofie",
            "Šimon",
            "Soňa",
            "Štěpán",
            "Stela",
            "Tadeáš",
            "Stella",
            "Teodor",
            "Šárka",
            "Theodor",
            "Šarlota",
            "Tobias",
            "Štěpánka",
            "Tobiáš",
            "Tereza",
            "Tomáš",
            "Terezie",
            "Václav",
            "Valentýna",
            "Viktor",
            "Valerie",
            "Vilém",
            "Valérie",
            "Vincent",
            "Vanesa",
            "Vít",
            "Vanessa",
            "Vítek",
            "Vendula",
            "Vladimír",
            "Veronika",
            "Vojta",
            "Viktorie",
            "Vojtěch",
            "Zuzana",
            "Zdeněk"});
            this.NameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.NameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.NameTextBox.Location = new System.Drawing.Point(140, 92);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(122, 27);
            this.NameTextBox.TabIndex = 5;
            this.NameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveBetweenTextBoxes);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Jméno";
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Nováková",
            "Novák",
            "Svobodová",
            "Svoboda",
            "Novotná",
            "Novotný",
            "Dvořáková",
            "Dvořák",
            "Černá",
            "Černý",
            "Šindler",
            "Šindlerová",
            "Procházková",
            "Procházka",
            "Kučerová",
            "Kučera",
            "Veselá",
            "Veselý",
            "Horáková",
            "Krejčí",
            "Horák",
            "Němcová",
            "Marková",
            "Němec",
            "Pokorná",
            "Pospíšilová",
            "Marek",
            "Pospíšil",
            "Pokorný",
            "Hájková",
            "Králová",
            "Jelínková",
            "Hájek",
            "Král",
            "Růžičková",
            "Benešová",
            "Jelínek",
            "Růžička",
            "Fialová",
            "Beneš",
            "Fiala",
            "Sedláčková",
            "Doležalová",
            "Zemanová",
            "Sedláček",
            "Doležal",
            "Zeman",
            "Kolářová",
            "Navrátilová",
            "Kolář",
            "Čermáková",
            "Navrátil",
            "Čermák",
            "Vaňková",
            "Urbanová",
            "Kratochvílová",
            "Vaněk",
            "Urban",
            "Šimková",
            "Blažková",
            "Křížová",
            "Kopecká",
            "Blažek",
            "Kříž",
            "Kovářová",
            "Bartošová",
            "Vlčková",
            "Poláková",
            "Kovář",
            "Kratochvíl",
            "Konečná",
            "Bartoš",
            "Vlček",
            "Polák",
            "Musil",
            "Kopecký",
            "Šimek",
            "Musilová",
            "Čechová",
            "Malá",
            "Staňková",
            "Štěpánková",
            "Konečný",
            "Holubová",
            "Malý",
            "Šťastná",
            "Kadlecová",
            "Dostálová",
            "Holub",
            "Čech",
            "Štěpánek",
            "Staněk",
            "Kadlec",
            "Dostál",
            "Soukupová",
            "Marešová",
            "Soukup",
            "Šťastný",
            "Sýkorová",
            "Valentová",
            "Moravcová",
            "Mareš",
            "Vávrová",
            "Tichá",
            "Moravec",
            "Sýkora",
            "Tichý",
            "Matoušková",
            "Bláhová",
            "Říhová",
            "Machová",
            "Valenta",
            "Mašková",
            "Ševčíková",
            "Vávra",
            "Matoušek",
            "Burešová",
            "Šmídová",
            "Říha",
            "Bláha",
            "Dušková",
            "Bureš",
            "Krejčová",
            "Pavlíková",
            "Jandová",
            "Ševčík",
            "Hrušková",
            "Havlíčková",
            "Hruška",
            "Mašek",
            "Hrubá",
            "Dušek",
            "Pavlík",
            "Havlíček",
            "Janda",
            "Hrubý",
            "Beranová",
            "Mach",
            "Lišková",
            "Tomanová",
            "Vacková",
            "Bednářová"});
            this.SurnameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SurnameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.SurnameTextBox.Location = new System.Drawing.Point(268, 92);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(122, 27);
            this.SurnameTextBox.TabIndex = 7;
            this.SurnameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveBetweenTextBoxes);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Příjmení";
            // 
            // CitytextBox
            // 
            this.CitytextBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Bělotín",
            "Beňov",
            "Bezuchov",
            "Bohuslávky",
            "Bochoř",
            "Brodek u Přerova",
            "Buk",
            "Býškovice",
            "Císařov",
            "Citov",
            "Čechy",
            "Čelechovice",
            "Černotín",
            "Dobrčice",
            "Dolní Nětčice",
            "Dolní Těšice",
            "Dolní Újezd",
            "Domaželice",
            "Dřevohostice",
            "Grymov",
            "Hlinsko",
            "Horní Moštěnice",
            "Horní Nětčice",
            "Horní Těšice",
            "Horní Újezd",
            "Hrabůvka",
            "Hradčany",
            "Hranice",
            "Hustopeče nad Bečvou",
            "Jezernice",
            "Jindřichov",
            "Kladníky",
            "Klokočí",
            "Kojetín",
            "Kokory",
            "Křenovice",
            "Křtomil",
            "Lazníčky",
            "Lazníky",
            "Lhota",
            "Lhotka",
            "Lipník nad Bečvou",
            "Lipová",
            "Líšná",
            "Lobodice",
            "Luboměř pod Strážnou",
            "Malhotice",
            "Měrovice nad Hanou",
            "Milenov",
            "Milotice nad Bečvou",
            "Nahošovice",
            "Nelešovice",
            "Oldřichov",
            "Olšovec",
            "Opatovice",
            "Oplocany",
            "Oprostovice",
            "Osek nad Bečvou",
            "Paršovice",
            "Partutovice",
            "Pavlovice u Přerova",
            "Podolí",
            "Polkovice",
            "Polom",
            "Potštát",
            "Prosenice",
            "Provodovice",
            "Přerov",
            "Přestavlky",
            "Radíkov",
            "Radkova Lhota",
            "Radkovy",
            "Radotín",
            "Radslavice",
            "Radvanice",
            "Rakov",
            "Rokytnice",
            "Rouské",
            "Říkovice",
            "Skalička",
            "Soběchleby",
            "Sobíšky",
            "Stará Ves",
            "Stříbrnice",
            "Střítež nad Ludinou",
            "Sušice",
            "Šišma",
            "Špičky",
            "Teplice nad Bečvou",
            "Tovačov",
            "Troubky",
            "Tučín",
            "Turovice",
            "Týn nad Bečvou",
            "Uhřičice",
            "Ústí",
            "Veselíčko",
            "Věžky",
            "Vlkoš",
            "Všechovice",
            "Výkleky",
            "Zábeštní Lhota",
            "Zámrsky",
            "Žákovice",
            "Želatovice",
            "Albrechtičky",
            "Bartošovice",
            "Bernartice nad Odrou",
            "Bílov",
            "Bílovec",
            "Bítov",
            "Bordovice",
            "Bravantice",
            "Frenštát pod Radhoštěm",
            "Fulnek",
            "Heřmanice u Oder",
            "Heřmánky",
            "Hladké Životice",
            "Hodslavice",
            "Hostašovice",
            "Jakubčovice nad Odrou",
            "Jeseník nad Odrou",
            "Jistebník",
            "Kateřinice",
            "Kopřivnice",
            "Kujavy",
            "Kunín",
            "Libhošť",
            "Lichnov",
            "Luboměř",
            "Mankovice",
            "Mořkov",
            "Mošnov",
            "Nový Jičín",
            "Odry",
            "Petřvald",
            "Příbor",
            "Pustějov",
            "Rybí",
            "Sedlnice",
            "Skotnice",
            "Slatina",
            "Spálov",
            "Starý Jičín",
            "Studénka",
            "Suchdol nad Odrou",
            "Šenov u Nového Jičína",
            "Štramberk",
            "Tichá",
            "Tísek",
            "Trnávka",
            "Trojanovice",
            "Velké Albrechtice",
            "Veřovice",
            "Vražné",
            "Vrchy",
            "Závišice",
            "Ženklava",
            "Životice u Nového Jičína",
            "Branky",
            "Bystřička",
            "Dolní Bečva",
            "Francova Lhota",
            "Halenkov",
            "Horní Bečva",
            "Horní Lideč",
            "Hošťálková",
            "Hovězí",
            "Huslenky",
            "Hutisko-Solanec",
            "Choryně",
            "Jablůnka",
            "Janová",
            "Jarcová",
            "Karolinka",
            "Kateřinice",
            "Kelč",
            "Kladeruby",
            "Krhová",
            "Kunovice",
            "Lačnov",
            "Leskovec",
            "Lešná",
            "Lhota u Vsetína",
            "Lidečko",
            "Liptál",
            "Loučka",
            "Lužná",
            "Malá Bystřice",
            "Mikulůvka",
            "Nový Hrozenkov",
            "Oznice",
            "Podolí",
            "Police",
            "Poličná",
            "Pozděchov",
            "Prlov",
            "Prostřední Bečva",
            "Pržno",
            "Ratiboř",
            "Rožnov pod Radhoštěm",
            "Růžďka",
            "Seninka",
            "Střelná",
            "Střítež nad Bečvou",
            "Ústí",
            "Valašská Bystřice",
            "Valašská Polanka",
            "Valašská Senice",
            "Valašské Meziříčí",
            "Velká Lhota",
            "Velké Karlovice",
            "Vidče",
            "Vigantice",
            "Vsetín",
            "Zašová",
            "Zděchov",
            "Zubří"});
            this.CitytextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CitytextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CitytextBox.Location = new System.Drawing.Point(12, 92);
            this.CitytextBox.Name = "CitytextBox";
            this.CitytextBox.Size = new System.Drawing.Size(122, 27);
            this.CitytextBox.TabIndex = 9;
            this.CitytextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveBetweenTextBoxes);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Obec";
            // 
            // PostalCodeTextBox
            // 
            this.PostalCodeTextBox.Location = new System.Drawing.Point(12, 149);
            this.PostalCodeTextBox.Name = "PostalCodeTextBox";
            this.PostalCodeTextBox.Size = new System.Drawing.Size(122, 27);
            this.PostalCodeTextBox.TabIndex = 11;
            this.PostalCodeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveBetweenTextBoxes);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "PSČ";
            // 
            // StreetTextBox
            // 
            this.StreetTextBox.Location = new System.Drawing.Point(140, 149);
            this.StreetTextBox.Name = "StreetTextBox";
            this.StreetTextBox.Size = new System.Drawing.Size(122, 27);
            this.StreetTextBox.TabIndex = 13;
            this.StreetTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveBetweenTextBoxes);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(140, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ulice";
            // 
            // DescriptiveNumberTextBox
            // 
            this.DescriptiveNumberTextBox.Location = new System.Drawing.Point(268, 149);
            this.DescriptiveNumberTextBox.Name = "DescriptiveNumberTextBox";
            this.DescriptiveNumberTextBox.Size = new System.Drawing.Size(122, 27);
            this.DescriptiveNumberTextBox.TabIndex = 15;
            this.DescriptiveNumberTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveBetweenTextBoxes);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(268, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Číslo Popisné";
            // 
            // CancelButton
            // 
            this.CancelButton.CausesValidation = false;
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(201, 204);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(146, 36);
            this.CancelButton.TabIndex = 16;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // AddPersonForm
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 262);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.DescriptiveNumberTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.StreetTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PostalCodeTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CitytextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BirthNumTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OKButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddPersonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddRecordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BirthNumTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CitytextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PostalCodeTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox StreetTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DescriptiveNumberTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button CancelButton;
    }
}