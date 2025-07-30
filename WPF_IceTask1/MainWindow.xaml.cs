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
using System.Xml.Linq;

namespace WPF_IceTask1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private NodeManager generateNode;
        private Node Head;
        private Node current;
        public MainWindow()
        {
            InitializeComponent();
            generateNode = new NodeManager();
            PopulateList(generateNode);
            Head = generateNode.Head;
            current = Head;
            txtNumOfNodesDisplay.Text = CountNodes(Head).ToString();

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
                    13, "The Firewall Fortress looms ahead, its defences formidable, but Alex's mastery of cybersecurity allows them to breach the walls with a series of perfectly timed hacks.");
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
                while(current.next != null)
                {
                    current = current.next;
                    counter++;
                }
                return counter;
            }

        //GUI Buttons that call methods
        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            if (current.previous != null)
            {
                current = current.previous;
                txtSingleNodeDisplay.Text = $"Previous node of {current.value} \nis: {current.previous.value}: \n{current.previous.contents}";
            }

            else if (current.previous == null)
            {
                txtSingleNodeDisplay.Text = $"No previous node found for:\n{current.value}: \n {current.contents}";
            }


        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            //Had to remove the Head node because it reset every time i clicked the next button,
            //which caused it to assign head as 6, and 'next' was always 10, and prev was always nonexsistant.
            if (current.next != null)
            {
                current = current.next;
                txtSingleNodeDisplay.Text = $"Next node of {current.previous.value} \nis: {current.value}: \n{current.contents}";
            }


            else if (current.next == null)
            {
                txtSingleNodeDisplay.Text = $"No next node found for:\n{current.value}: \n{current.contents}";
            }


        }

        private void btnGetList_Click(object sender, RoutedEventArgs e)
        {
            lboxListDisplay.Items.Clear();
            Node current = Head;
            string fullList = "";
            for (int i = 0; i < CountNodes(Head); i++)
            {
                lboxListDisplay.Items.Add($"{current.value}: {current.contents}\r");
                current = current.next;
            }
        }

        private void btnSortList_Click(object sender, RoutedEventArgs e)
        {
            lboxListDisplay.Items.Clear();
            Node current = Head;
            Node currentSort;

            for (int i = 0; i < CountNodes(Head); i++)
            {
                currentSort = Head;
                for (int j = 0; j < CountNodes(Head); j++)
                {
                    if (currentSort.value > currentSort.next.value)
                    {
                        //must bubble sort the value and the contents within the node
                        int tempValue = currentSort.value;
                        string tempContents = currentSort.contents;


                        currentSort.value = currentSort.next.value;
                        currentSort.contents = currentSort.next.contents;

                        currentSort.next.value = tempValue;
                        currentSort.next.contents = tempContents;

                        //original method but setting the previous and next Node
                        //current = current.previous;
                        //Node tempNode = currentSort;

                        //currentSort = currentSort.next;

                        //currentSort.next = tempNode;

                    }
                    currentSort = currentSort.next;
                }
                lboxListDisplay.Items.Add($"{current.value}: {current.contents}\r");
            }

            //Displaying the sorted order
            //while (current.next != null)
            //{
            //    lboxListDisplay.Items.Add($"{current.value}");
            //    current = current.next;
            //}

        }

    }
}