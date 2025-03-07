using PaymentManagment.Entity;
using PaymentManagment.Payments;
using PaymentManagment.Repository;
using System.Threading.Tasks;

namespace PaymentManagment
{
    public partial class Form1 : Form
    {
        public IPaymentService ipaymentService;
        public PaymentService paymentservice;
        public IPaymentRepository _paymentRepository;
        public Form1(IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PaymentButton_Click(object sender, EventArgs e)
        {
            PaymentFactory factory = new PaymentFactory();
            ipaymentService = factory.GetInstance(comboBox1.SelectedValue.ToString());
            paymentservice = new PaymentService(ipaymentService);
            MessageBox.Show(ipaymentService.Pay(textBox1.Text));
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadComboBox();
        }

        private async Task LoadComboBox()
        {
            var payments =await _paymentRepository.GetAllPaymentsAsync();
            comboBox1.DataSource = payments;
            comboBox1.DisplayMember = "DisplayName";  // ComboBoxta gösterilecek özellik
            comboBox1.ValueMember = "DatabaseName";      // Seçildiðinde alýnacak deðer
        }
    }
}
