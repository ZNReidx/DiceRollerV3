namespace DiceRoller
{
    public partial class MainPage : ContentPage
    {
        public MainPage(){
           InitializeComponent();
        }
        private void RandomBtn_Clicked(object sender, EventArgs e){
            if (int.TryParse(entradaLados.Text, out int numbers)){
                Random random = new Random();
            
                int lados = Convert.ToInt32(entradaLados.Text);
                numbers = random.Next(1, lados + 1);
                resultadoLabel.Text = $"Resultado: {numbers}";   
            }
            
        }

       
    }

}
