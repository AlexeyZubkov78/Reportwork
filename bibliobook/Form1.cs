namespace bibliobook;

public partial class Form1 : Form
{
    public static List<string> Readers { get; set; } = new List<string>()
    {
      "������� �.�.", "����������� �.�.", "������ �.�.", "������ �.�.", "������� �.�"
    };

    public static List<string> Books { get; set; } = new List<string>()
 {
   "����������� \"�����\"", "������ \"������� ���������\"", "��������� \"�����\"",
   "������� \"����� � ���\""
 };
    public Dictionary<string, List<string>> Info { get; set; } = new Dictionary<string, List<string>>();
    public Form1()
    {
        InitializeComponent();
    }

    public bool UpdateReaders(List<string> items, int index = 0)
    {
        try
        {
            if (items.Count != 0)
            {
                cmbReader.Items.Clear();
                cmbReader.Items.AddRange(items.ToArray());
                cmbReader.SelectedIndex = index;        // ���������/������� �������� ������
                return true;
            }
       else
            {
                cmbReader.Items.Clear();
                return false;
            }
        }
        catch (Exception ex)
        {
            return false;
        }
    }

    public bool UpdateBooks(List<string> items, int index = 0)
    {
        try
        {
            if (items.Count != 0)
            {
                lstBooks.Items.Clear();
                lstBooks.Items.AddRange(items.ToArray());
                lstBooks.SelectedIndex = index;        // ���������/������� �������� ������
                return true;
            }
            else
            {
                lstBooks.Items.Clear();
                return false;
            }
        }
        catch (Exception ex)
        {
            return false;
        }
    }
    private void Form1_Load(object sender, EventArgs e)
    {
        UpdateReaders(Readers);
        UpdateBooks(Books);		
    }
    private void btnInform_Click(object sender, EventArgs e)
    {
        grbInform.Visible = true;
        btnRemove.Enabled = true;
        btnClear.Enabled = true;
        btnVisibleInform.Enabled = true;
        lstInform.Items.Clear();
        lstInform.Items.Add(cmbReader.Text);    // ���������� ������ �������� � ������
        if (rdbStatus1.Checked)
            lstInform.Items.Add(rdbStatus1.Text);
        else if (rdbStatus2.Checked)
            lstInform.Items.Add(rdbStatus2.Text);
        else
            lstInform.Items.Add(rdbStatus3.Text);
        if (chkBook.Checked)
            lstInform.Items.Add("����� �� �����");
        lstInform.Items.Add(lstBooks.Text);
        lstInform.Items.Add("���������� ���� " + txtKol.Text);
        lstInform.SelectedIndex = lstInform.Items.Count - 1;
    }
    public bool RemoveBook(string item, List<string> list)
    {
        var iSContains = Books.Contains(item);
        if (iSContains)
        {
            Books.Remove(item);
            UpdateBooks(Books);
            return true;
        };
    return false;
    }
    private void btnRemove_Click(object sender, EventArgs e)
    {
        RemoveBook(lstInform.Text, Books);
        lstInform.Items.Remove(lstInform.Text); // �������� ����������� ��������
        lstInform.SelectedIndex = lstInform.Items.Count - 1; // ��������� ���������� ��������

        if (lstInform.Items.Count == 0)
        {// ���� ������ ������, ����� ������ ����������
            btnRemove.Enabled = false;
            btnClear.Enabled = false;
        }
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        lstInform.Items.Clear();        // ������� ��������� ������
        btnRemove.Enabled = false;      // ������ �������� ������ ����������
        btnClear.Enabled = false;		// ������ ���������� ����������
    }

    private void btnVisibleInform_Click(object sender, EventArgs e)
    {
        grbInform.Visible = false;      // ����� ������������ ��������
        btnRemove.Enabled = false;      // ������ �������� ������ ����������
        btnClear.Enabled = false;       // ������ ���������� ����������
        btnVisibleInform.Enabled = false;	// ������ ������� ����������� ����������
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        Close();					// �������� ����������
    }
}
