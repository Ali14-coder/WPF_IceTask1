using System.Collections;
using System.Diagnostics.Metrics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_IceTask1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private NodeManager generateNode;
        private Node Head;
        public MainWindow()
        {
            InitializeComponent();
            generateNode = new NodeManager();
            //assigning head to the top of added Nodes;
            PopulateList(generateNode);
            Head = generateNode.Head;
            txtNumOfNodesDisplay.Text = CountNodes(Head).ToString();
            //Console.WriteLine("Entire linked list: "+DisplayEntireList(Head));
            //SortList(Head);
            //Console.WriteLine("Sorted entire list: "+ DisplayEntireList(Head));
            //Console.WriteLine("Current node: "+DisplaySingleNode(Head));
        }

            //Populate linkedlist
            public static void PopulateList(NodeManager generateNode) 
            {
                //Adding a value to the node
                generateNode.Add(
                    6, "Emerging victorious, Alex discovers the hidden Repository of the Ancients, a collection of long-lost IT texts rumoured to contain the ultimate programming language."
                    );
                generateNode.Add(
                    10, "Victory is hard-won, but Alex's leadership and IT prowess lead to the defeat of the Malware Marauders, restoring peace to Cybersphere.");
                generateNode.Add(
                    3, "With every line of code mastered, Alex gains experience points, levelling up and unlocking new abilities like Debugging Dash and Algorithmic Aura.");
                generateNode.Add(
                    4, "The Firewall Fortress looms ahead, its defences formidable, but Alex's mastery of cybersecurity allows them to breach the walls with a series of perfectly timed hacks.");
                generateNode.Add(
                    11, "Celebrated as a digital hero, Alex stands at the forefront of innovation, using the knowledge gained to create groundbreaking applications that shape the future of technology.");
                generateNode.Add(
                    9, "In a climactic battle, Alex and the Syntax Sentinels engage in a virtual war, using complex algorithms and strategic thinking to outwit the Malware Marauders' schemes.");
                generateNode.Add(
                    12, "The tale of Alex, the IT student-turned-digital-legend, is forever etched in the annals of Cybersphere, inspiring aspiring programmers to pursue their dreams.");
                generateNode.Add(
                    7, "Along the journey, Alex forges alliances with NPC coders, forming a guild known as \"Syntax Sentinels,\" united by their dedication to digital mastery.");
                generateNode.Add(
                    5, "Inside the fortress, a virtual reality riddle awaits – a puzzle that can only be solved by applying principles of encryption and decryption learned during countless late-night study sessions.");
                generateNode.Add(
                    4, "The Firewall Fortress looms ahead, its defences formidable, but Alex's mastery of cybersecurity allows them to breach the walls with a series of perfectly timed hacks.");
                generateNode.Add(
                    8, "The guild faces its nemesis in the form of the Malware Marauders, a rival group aiming to spread chaos and disrupt the digital realm.");
                generateNode.Add(
                    2, "Armed with a trusty keyboard and a digital sword, Alex enters the Coding Caverns, where bugs and glitches guard the treasures of programming wisdom.");
                generateNode.Add(
                    1, "In the virtual realm of Cybersphere, our hero, Alex, a determined IT student, embarks on an epic quest for knowledge.");

            }

            //Node count method
            public static int CountNodes(Node Head)
            {
                Node current = Head;
                int counter = 1; 
                while(current != null)
                {
                    counter++;
                    current = current.next;
                }
                return counter;
            }
            //Sort out linkedlist
            public static string SortList(Node Head)
            {
                Node current = Head;
                Node largestNode = Head;
                string sortedList = "";

                for (int i = 0; i < CountNodes(Head); i++)
                {
                    for (int j = 0; j < CountNodes(current); j++)
                    {
                        if (current.value > current.next.value)
                        {
                            Node temp = current;
                            current = current.next;
                            current.next = temp;

                        }
                    }
                    sortedList = current+"\n";
                }
                return sortedList;
            }
            //Display full linked list
            public static string DisplayEntireList(Node Head)
            {
                Node current = Head;
                string fullList = "";
                while(current != null ) 
                {
                    fullList = "current\n";
                    current = current.next;
                }
                return fullList;    
            }

            //Display previous single node in list
            public static Node DisplayNextSingleNode(Node Head)
            {
                Node current = Head;
                bool selectNext = false;
                bool selectPrevious = false;

            if (selectNext == true)
            {
                current = current.next;
                Console.WriteLine(current);
            }
           
            else 
            { 
                return null; 
            }

                return current;
            }

        //Display next single node in list
        public static Node DisplayPreviousSingleNode(Node Head)
        {
            Node current = Head;
            bool selectNext = false;
            bool selectPrevious = false;

            if (selectPrevious == true)
            {
                current = current.previous;
                Console.WriteLine(current);
            }
            else
            {
                return null;
            }

            return current;
        }

        //GUI Buttons that call methods
        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            DisplayPreviousSingleNode(Head);
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            //rtSingleNodeDisplay.Document.Blocks.Add(DisplayNextSingleNode(Head));

        }

        private void btnGetList_Click(object sender, RoutedEventArgs e)
        {
            lboxUnsortedListDisplay.Items.Clear();
            lboxUnsortedListDisplay.Items.Add(DisplayEntireList(Head));
        }

        private void btnSortList_Click(object sender, RoutedEventArgs e)
        {
            lboxUnsortedListDisplay.Items.Clear();
            lboxUnsortedListDisplay.Items.Add(SortList(Head));
        }

    }
}