using MarkdownWikiGeneratorCore;
using System.Diagnostics;
using System.Text;

namespace WikiMaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string target = string.Empty;
            string dest = "docs";
            string namespaceMatch = string.Empty;
            int size = -1;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                target = openFileDialog1.FileName;
                Debug.WriteLine(target);
            }
            MarkdownableType[] types = MarkdownGenerator.Load(target, namespaceMatch);
            foreach (MarkdownableType type in types)
                Console.WriteLine(type.Name);
            Debug.WriteLine("28");
            // Home Markdown Builder
            MarkdownBuilder homeBuilder = new MarkdownBuilder();
            homeBuilder.Header(1, "References");
            homeBuilder.AppendLine();
            Debug.WriteLine("33");
            bool working = false;
            foreach (IGrouping<string, MarkdownableType> g in types.GroupBy(x => x.Namespace).OrderBy(x => x.Key))
            {

                working = true;
                if (!Directory.Exists(dest))
                {
                    Directory.CreateDirectory(dest);
                }

                homeBuilder.HeaderWithLink(2, g.Key, g.Key);
                homeBuilder.AppendLine();
                StringBuilder sb = new StringBuilder();
                foreach (MarkdownableType item in g.OrderBy(x => x.Name))
                {
                    homeBuilder.ListLink(MarkdownBuilder.MarkdownCodeQuote(item.BeautifyName), g.Key + "#" + item.BeautifyName.Replace("<", "").Replace(">", "").Replace(",", "").Replace(" ", "-").ToLower());
                    Debug.WriteLine("48");
                    sb.Append(item.ToString());
                }
                File.WriteAllText(Path.Combine(dest, g.Key + ".md"), sb.ToString());
                homeBuilder.AppendLine();
            }
            if(working == false)
            {
                Worked.Text = "Unsupported project/dll or not selected as Debug.dll";
            }
            else
            {
                Process.Start("explorer.exe", Path.Combine(Environment.CurrentDirectory, "docs"));
            }            
            // Gen Home
            File.WriteAllText(Path.Combine(dest, "Home.md"), homeBuilder.ToString());
            Console.WriteLine(size); // <-- Shows file size in debugging mode.
            Console.WriteLine(result); Debug.WriteLine("59");// <-- For debugging use. 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}