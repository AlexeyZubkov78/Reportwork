namespace bibliobook;

public partial class Form1 : Form
{
    public static List<string> Readers { get; set; } = new List<string>()
    {
      "Арбузов Н.В.", "Вылегжанина О.Ю.", "Иванов П.Р.", "Петров С.Е.", "Сидоров А.И"
    };

    public static List<string> Books { get; set; } = new List<string>()
 {
   "Достоевский \"Идиот\"", "Куприн \"Сборник рассказов\"", "Лермонтов \"Мцыри\"",
   "Толстой \"Война и мир\""
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
                cmbReader.SelectedIndex = index;        // выделение/первого элемента списка
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
                lstBooks.SelectedIndex = index;        // выделение/первого элемента списка
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
        lstInform.Items.Add(cmbReader.Text);    // добавление нового элемента в список
        if (rdbStatus1.Checked)
            lstInform.Items.Add(rdbStatus1.Text);
        else if (rdbStatus2.Checked)
            lstInform.Items.Add(rdbStatus2.Text);
        else
            lstInform.Items.Add(rdbStatus3.Text);
        if (chkBook.Checked)
            lstInform.Items.Add("Книги на руках");
        lstInform.Items.Add(lstBooks.Text);
        lstInform.Items.Add("Количество дней " + txtKol.Text);
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
        lstInform.Items.Remove(lstInform.Text); // удаление выделенного элемента
        lstInform.SelectedIndex = lstInform.Items.Count - 1; // выделение последнего элемента

        if (lstInform.Items.Count == 0)
        {// если список пустой, тогда кнопки недоступны
            btnRemove.Enabled = false;
            btnClear.Enabled = false;
        }
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        lstInform.Items.Clear();        // очистка элементов списка
        btnRemove.Enabled = false;      // кнопка «Удалить строку» недоступна
        btnClear.Enabled = false;		// кнопка «Очистить» недоступна
    }

    private void btnVisibleInform_Click(object sender, EventArgs e)
    {
        grbInform.Visible = false;      // рамка «Информация» невидима
        btnRemove.Enabled = false;      // кнопка «Удалить строку» недоступна
        btnClear.Enabled = false;       // кнопка «Очистить» недоступна
        btnVisibleInform.Enabled = false;	// кнопка «Скрыть информацию» недоступна
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        Close();					// закрытие приложения
    }
}
