using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Globalization;
using System.IO;
namespace NewCalculator
{
	public class NewCalculatorForm:Form
	{
		public Button One;
		public Button Two;
		public Button Three;
		public Button Four;
		public Button Fife;
		public Button Sex;
		public Button Seven;
		public Button Eight;
		public Button Nine;
		public Button Zero;
		public Button Apostrof;

		//Bajaradigan funksiyalar
		public Button Qushish;
		public Button Ayirish;
		public Button Kupaytirish;
		public Button Bulish;
		public Button Result;
		public Button Clear;
		public Button Exit;
		public Button Backsape;
		public Button History;
		public Button HistoryRemoved;

		//Sonni kiritish
		public TextBox NumberCalc;

		//Qaysi kordinataligini belgilash
		public int x=100;
		public int y=200;

		//Muallif
		public Label Muallif;
		

		public NewCalculatorForm()
		{
			//Formani ko'rinishi
			this.FormBorderStyle=FormBorderStyle.FixedDialog;
			this.Width=(2*x+200);
			this.Height=(2*(y-70)+400);
			this.Text="NafisaCalculator";
		


			NumberCalc=new TextBox();
			this.NumberCalc.Width=200;
			this.NumberCalc.Height=50;
			this.NumberCalc.Text="";
			this.NumberCalc.Name="WriteCalculator";
			this.NumberCalc.Location =new System.Drawing.Point(x,y-170);
			this.NumberCalc.MaxLength=20;
			this.NumberCalc.ReadOnly=true;
			this.NumberCalc.BackColor=Color.Black;
			this.NumberCalc.ForeColor=Color.White;
			this.NumberCalc.BorderStyle=BorderStyle.Fixed3D;
			this.Controls.Add(NumberCalc);

			Backsape=new Button();
			this.Backsape.Width=100;
			this.Backsape.Height=50;
			this.Backsape.Text="Orqaga";			
			this.Backsape.Location =new System.Drawing.Point(x+100,y-150);
			this.Controls.Add(Backsape);
			this.Backsape.Click += new EventHandler(Backsape_Click);

			History=new Button();
			this.History.Width=100;
			this.History.Height=50;
			this.History.Text="Tarix";			
			this.History.Location =new System.Drawing.Point(x,y-150);
			this.Controls.Add(History);
			this.History.Click += new EventHandler(History_Click);

			HistoryRemoved=new Button();
			this.HistoryRemoved.Width=200;
			this.HistoryRemoved.Height=50;
			this.HistoryRemoved.Text="Tarixni tozalash";
			this.HistoryRemoved.Location =new System.Drawing.Point(x,y-100);
			this.HistoryRemoved.Click += new EventHandler(HistoryRemoved_Click);
			this.Controls.Add(HistoryRemoved);


			//Sonlar
			One=new Button();
			this.One.Width=50;
			this.One.Height=50;
			this.One.Text="1";
			this.One.Location =new System.Drawing.Point(x,y);
			this.Controls.Add(One);
			this.One.Click += new EventHandler(One_Click);

			Two=new Button();
			this.Two.Width=50;
			this.Two.Height=50;
			this.Two.Text="2";
			this.Two.Location =new System.Drawing.Point(x+50,y);
			this.Controls.Add(Two);
			this.Two.Click += new EventHandler(Two_Click);

			Three=new Button();
			this.Three.Width=50;
			this.Three.Height=50;
			this.Three.Text="3";
			this.Three.Location =new System.Drawing.Point(x+100,y);
			this.Controls.Add(Three);
			this.Three.Click += new EventHandler(Three_Click);

			Four=new Button();
			this.Four.Width=50;
			this.Four.Height=50;
			this.Four.Text="4";
			this.Four.Location =new System.Drawing.Point(x,y+50);
			this.Controls.Add(Four);
			this.Four.Click += new EventHandler(Four_Click);

			Fife=new Button();
			this.Fife.Width=50;
			this.Fife.Height=50;
			this.Fife.Text="5";
			this.Fife.Location =new System.Drawing.Point(x+50,y+50);
			this.Controls.Add(Fife);
			this.Fife.Click += new EventHandler(Fife_Click);

			Sex=new Button();
			this.Sex.Width=50;
			this.Sex.Height=50;
			this.Sex.Text="6";
			this.Sex.Location =new System.Drawing.Point(x+100,y+50);
			this.Controls.Add(Sex);
			this.Sex.Click += new EventHandler(Sex_Click);

			Seven=new Button();
			this.Seven.Width=50;
			this.Seven.Height=50;
			this.Seven.Text="7";
			this.Seven.Location =new System.Drawing.Point(x,y+100);
			this.Controls.Add(Seven);
			this.Seven.Click += new EventHandler(Seven_Click);

			Eight=new Button();
			this.Eight.Width=50;
			this.Eight.Height=50;
			this.Eight.Text="8";
			this.Eight.Location =new System.Drawing.Point(x+50,y+100);
			this.Controls.Add(Eight);
			this.Eight.Click += new EventHandler(Eight_Click);

			Nine=new Button();
			this.Nine.Width=50;
			this.Nine.Height=50;
			this.Nine.Text="9";
			this.Nine.Location =new System.Drawing.Point(x+100,y+100);
			this.Controls.Add(Nine);
			this.Nine.Click += new EventHandler(Nine_Click);

			Zero=new Button();
			this.Zero.Width=100;
			this.Zero.Height=50;
			this.Zero.Text="0";
			this.Zero.Location =new System.Drawing.Point(x,y+150);
			this.Controls.Add(Zero);
			this.Zero.Click += new EventHandler(Zero_Click);

			Apostrof=new Button();
			this.Apostrof.Width=50;
			this.Apostrof.Height=50;
			this.Apostrof.Text=",";
			this.Apostrof.Location =new System.Drawing.Point(x+100,y+150);
			this.Controls.Add(Apostrof);
			this.Apostrof.Click += new EventHandler(Apostrof_Click);

			Clear=new Button();
			this.Clear.Width=50;
			this.Clear.Height=50;
			this.Clear.Text="C";
			this.Clear.Location =new System.Drawing.Point(x,y-50);
			this.Clear.Click += new EventHandler(Clear_Click);
			this.Controls.Add(Clear);


			Bulish=new Button();
			this.Bulish.Width=50;
			this.Bulish.Height=50;
			this.Bulish.Text="/";
			this.Bulish.Location =new System.Drawing.Point(x+50,y-50);
			this.Controls.Add(Bulish);
			this.Bulish.Click += new EventHandler(Bulish_Click);

			Kupaytirish=new Button();
			this.Kupaytirish.Width=50;
			this.Kupaytirish.Height=50;
			this.Kupaytirish.Text="*";
			this.Kupaytirish.Location =new System.Drawing.Point(x+100,y-50);
			this.Controls.Add(Kupaytirish);
			this.Kupaytirish.Click += new EventHandler(Kupaytirish_Click);

			Ayirish=new Button();
			this.Ayirish.Width=50;
			this.Ayirish.Height=50;
			this.Ayirish.Text="-";
			this.Ayirish.Location =new System.Drawing.Point(x+150,y-50);
			this.Controls.Add(Ayirish);
			this.Ayirish.Click += new EventHandler(Ayirish_Click);

			Qushish=new Button();
			this.Qushish.Width=50;
			this.Qushish.Height=100;
			this.Qushish.Text="+";
			this.Qushish.Location =new System.Drawing.Point(x+150,y);
			this.Controls.Add(Qushish);
			this.Qushish.Click += new EventHandler(Qushish_Click);

			Result=new Button();
			this.Result.Width=50;
			this.Result.Height=100;
			this.Result.Text="=";
			this.Result.Location =new System.Drawing.Point(x+150,y+100);
			this.Controls.Add(Result);
			this.Result.Click += new EventHandler(Result_Click);

			Exit=new Button();
			this.Exit.Width=200;
			this.Exit.Height=50;
			this.Exit.Text="Dasturdan chiqish";
			this.Exit.Location =new System.Drawing.Point(x,y+200);
			this.Controls.Add(Exit);
			this.Exit.Click += new EventHandler(Exit_Click);
			
			Muallif=new Label();
			this.Muallif.Width=250;
			this.Muallif.Height=50;
			this.Muallif.Text="Ushbu dastur C# da yaratildi \nDastur muallifi Abdunazarova Nafisa";
			this.Muallif.Location =new System.Drawing.Point(x,y+270);
			//this.Muallif.BackColor=Color.Yellow;
			//this.Muallif.ForeColor=Color.Yellow;
			this.Controls.Add(Muallif);

			

		}
		   
            //Sonlarni kiritamiz
            public void One_Click(object sender, EventArgs e)
            {
            	if(NumberCalc.Text=="0")
            	{
            		NumberCalc.Text="1";
            	}else
            	{
            		NumberCalc.Text=NumberCalc.Text+"1";
            	}
            }
             ///<summary>
            /// 1sds
            ///</summary>
            public void Two_Click(object sender, EventArgs e)
            {
           
            	if(NumberCalc.Text=="0")
            	{
            		NumberCalc.Text="2";
            	}else
            	{
            		NumberCalc.Text=NumberCalc.Text+"2";
            	}
            }
            public void Three_Click(object sender, EventArgs e)
            {
            	if(NumberCalc.Text=="0")
            	{
            		NumberCalc.Text="3";
            	}else
            	{
            		NumberCalc.Text=NumberCalc.Text+"3";
            	}
            }
            public void Four_Click(object sender, EventArgs e)
            {
            	if(NumberCalc.Text=="0")
            	{
            		NumberCalc.Text="4";
            	}else
            	{
            		NumberCalc.Text=NumberCalc.Text+"4";
            	}
            }
            public void Fife_Click(object sender, EventArgs e)
            {
            	if(NumberCalc.Text=="0")
            	{
            		NumberCalc.Text="5";
            	}else
            	{
            		NumberCalc.Text=NumberCalc.Text+"5";
            	}
            }
            public void Sex_Click(object sender, EventArgs e)
            {
            	if(NumberCalc.Text=="0")
            	{
            		NumberCalc.Text="6";
            	}else
            	{
            		NumberCalc.Text=NumberCalc.Text+"6";
            	}
            }
            public void Seven_Click(object sender, EventArgs e)
            {
            	if(NumberCalc.Text=="0")
            	{
            		NumberCalc.Text="7";
            	}else
            	{
            		NumberCalc.Text=NumberCalc.Text+"7";
            	}
            }
            public void Eight_Click(object sender, EventArgs e)
            {
            	if(NumberCalc.Text=="0")
            	{
            		NumberCalc.Text="8";
            	}else
            	{
            		NumberCalc.Text=NumberCalc.Text+"8";
            	}
            }
            public void Nine_Click(object sender, EventArgs e)
            {
            	if(NumberCalc.Text=="0")
            	{
            		NumberCalc.Text="9";
            	}else
            	{
            		NumberCalc.Text=NumberCalc.Text+"9";
            	}
            }
            public void Apostrof_Click(object sender, EventArgs e)
            {
            	if(NumberCalc.Text=="0")
            	{
            		NumberCalc.Text="0,";
            	}else
            	{
            		NumberCalc.Text=NumberCalc.Text+",";
            	}
            	if(NumberCalc.Text==",,")
            	{
            		NumberCalc.Text=NumberCalc.Text.Remove(NumberCalc.Text.Length-1,1);
            	}
            	if(NumberCalc.Text==",")
            	{
            		NumberCalc.Text="0,";
            	}
            }

            public void Zero_Click(object sender, EventArgs e)
            {
            	if(NumberCalc.Text=="0")
            	{
            		NumberCalc.Text="0";
            	}else
            	{
            		NumberCalc.Text=NumberCalc.Text+"0";
            	}
            	
            }
            //Asosiy dastur kodlari 
            public string FirstVariable;
            public string SecondVariable;

            public int FirstVariableLength;
            public int SecondVariableLength;

            public float FirstVariableNumber;
            public float SecondVariableNumber;

            public string HistoryString;
            public string MyString;
             
            public void Exit_Click(object sender,EventArgs e)
            {
            	Close();
            }

            public void Clear_Click(object sender,EventArgs e)
            {
            	NumberCalc.Clear();
            }
            BacendCalculator MyCode = new BacendCalculator();

           
           public void Qushish_Click(object sender, EventArgs e)
            {
            	FirstVariable=NumberCalc.Text;
            		
            	NumberCalc.Text=NumberCalc.Text+"+";
            			
            	FirstVariableLength=(NumberCalc.Text.Length-1);
            }
            public void Ayirish_Click(object sender, EventArgs e)
            {
            	FirstVariable=NumberCalc.Text;
            	NumberCalc.Text=NumberCalc.Text+"-";
            	FirstVariableLength=(NumberCalc.Text.Length-1);
            }
            public void Bulish_Click(object sender, EventArgs e)
            {
            	FirstVariable=NumberCalc.Text;
            	NumberCalc.Text=NumberCalc.Text+"/";
            	FirstVariableLength=(NumberCalc.Text.Length-1);
            }
            public void Kupaytirish_Click(object sender, EventArgs e)
            {
            	FirstVariable=NumberCalc.Text;
            	NumberCalc.Text=NumberCalc.Text+"*";
            	FirstVariableLength=(NumberCalc.Text.Length-1);
            }
            public int FindCalculator(string Soz,string QidiriladiganSoz)
            {
            	int i;
            	int k=0;
            	for(i=0;i<=Soz.Length-1;i++)
            	{
            		if(Soz.Substring(i,1)==QidiriladiganSoz)
            		{
            			k=k+1;
            		}
            	}
            	return k;
            }
            public void Result_Click(object sender, EventArgs e)
            {
            	try
            	{
            		int Plus;
            	int Minus;
            	int Barobar;
            	int Kupaytma;
            	int Bulinma;

            	Plus=FindCalculator(NumberCalc.Text,"+");
            	Minus=FindCalculator(NumberCalc.Text,"-");
            	Kupaytma=FindCalculator(NumberCalc.Text,"*");
            	Bulinma=FindCalculator(NumberCalc.Text,"/");
            	Barobar=FindCalculator(NumberCalc.Text,"=");
            		
                if((Plus>1)||(Minus>1)||(Bulinma>1)||(Kupaytma>1)||(Barobar>1))
            	{
            			MessageBox.Show("Dastur ishlashida xatolik yuz berdi!!!\nBu funksiyani NafisaCalculator hisoblay olmaydi!!!","Xato",MessageBoxButtons.OK,MessageBoxIcon.Error);
            			NumberCalc.Text=NumberCalc.Text+"=Xato";
            	}else
            	{
            		//MessageBox.Show(FindCalculator(NumberCalc.Text,"+").ToString());
            		SecondVariableLength=(NumberCalc.Text.Length-FirstVariableLength-1);
            		NumberCalc.Text=NumberCalc.Text+"=";
            		SecondVariable=NumberCalc.Text.Substring((FirstVariableLength+1),SecondVariableLength);

            		//Son holatiga o'tkazish
            		FirstVariableNumber=Convert.ToSingle(FirstVariable);
            		SecondVariableNumber=Convert.ToSingle(SecondVariable);

	            	if(NumberCalc.Text.Substring(FirstVariableLength,1)=="+")
	            	{
	            		NumberCalc.Text=NumberCalc.Text+MyCode.QushishNumber(FirstVariableNumber,SecondVariableNumber);
	            	}else if(NumberCalc.Text.Substring(FirstVariableLength,1)=="-")
	            	{
	            		NumberCalc.Text=NumberCalc.Text+MyCode.AyirishNumber(FirstVariableNumber,SecondVariableNumber);
	            	}else if(NumberCalc.Text.Substring(FirstVariableLength,1)=="*")
	            	{
	            		NumberCalc.Text=NumberCalc.Text+MyCode.KupaytirishNumber(FirstVariableNumber,SecondVariableNumber);
	            	}else if(NumberCalc.Text.Substring(FirstVariableLength,1)=="/")
	            	{
	            		if(SecondVariableNumber==0)
	            		{
	            			MessageBox.Show("Dastur ishlashida xatolik yuz berdi!!!\nIltimos ikkinchi songa 0 kiritmang!!!","Hato",MessageBoxButtons.OK,MessageBoxIcon.Error);
	            		}else
	            		{
	            			NumberCalc.Text=NumberCalc.Text+MyCode.BulishNumber(FirstVariableNumber,SecondVariableNumber);
	            		}
	            	}
	            }
	            
            	}catch(Exception ex)
            	{
            		MessageBox.Show("Dastur ishlashida hatolik yuz berdi!!!\nBu funksiyani NafisaCalculator hisoblay olmaydi!!!","Xato",MessageBoxButtons.OK,MessageBoxIcon.Error);
            		NumberCalc.Text=NumberCalc.Text+"Xato";
            	}
            	HistoryString=NumberCalc.Text;

	            string path =@"History.txt";
		        using (StreamWriter sw = File.AppendText(path))
		        {
		            sw.WriteLine(HistoryString);
		        }
            	
	            	
            }


            public void Backsape_Click(object sender, EventArgs e)
            {
            	if(NumberCalc.Text=="")
            	{
            		MessageBox.Show("Hech narsa qolmadi!!!","So'z yo'q",MessageBoxButtons.OK,MessageBoxIcon.Error);
            	}else
            	{
                NumberCalc.Text=NumberCalc.Text.Remove(NumberCalc.Text.Length-1,1);
                }
            }


            HistoryCalc MyHistory=new HistoryCalc();

            public void History_Click(object sender,EventArgs e)
            {
            	try
            	{
            		string path =@"History.txt";
            	
            		using (StreamReader sr = File.OpenText(path))
				        {
				        	MyString=sr.ReadToEnd();
				        }
		            MessageBox.Show(MyString.ToString(),"Tarix",MessageBoxButtons.OK,MessageBoxIcon.Information);
            	 
		        }catch(Exception ex)
		        {
		        	MessageBox.Show("Tarix tozalangan","Tarix",MessageBoxButtons.OK,MessageBoxIcon.Information);
		        }
            	 

		            	 
		        
		    }
		    public void HistoryRemoved_Click(object sender,EventArgs e)
		    {
		    	string path=@"History.txt";
		    	 File.Delete(path);
		        
            	MessageBox.Show("Tarix tozalandi","Tarix",MessageBoxButtons.OK,MessageBoxIcon.Information);
		    
		    }
            


		public void MyCalcRun()
		{
			Application.Run(new NewCalculatorForm());
		}
	}

	public class BacendCalculator
	{
		public static void Main()
		{
		  NewCalculatorForm MyRun= new NewCalculatorForm();
           MyRun.MyCalcRun();
		}
		public float QushishNumber(float a,float b)
		{
			float x=a;
			float y=b;
			return (x+y);
		}
		public float AyirishNumber(float a,float b)
		{
			float x=a;
			float y=b;
			return (x-y);
		}
		public float KupaytirishNumber(float a,float b)
		{
			float x=a;
			float y=b;
			return (x*y);
		}
		public float BulishNumber(float a,float b)
		{
		    float x=a;
			float y=b;
			return (x/y);
		}

			
	}
	public class HistoryCalc:Form
	{
		public HistoryCalc()
		{
			this.Text="History";
		    this.Width=800;
		    this.Height=500;
		}
		
	}
}