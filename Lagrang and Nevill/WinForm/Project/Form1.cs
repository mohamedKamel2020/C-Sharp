namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double[] xValues = Array.ConvertAll(txtX.Text.Split(','), double.Parse);

                double[] yValues = Array.ConvertAll(txtY.Text.Split(','), double.Parse);
                double xTarget;
                double.TryParse(targetX.Text, out xTarget);

                double result = LagrangMethod(xValues, yValues, xTarget);

                labelResult.Text = $"P({xTarget}) = {result}";
            }
            catch (Exception ex) { MessageBox.Show($"Error: {ex.Message}"); }
        }
        static double LagrangMethod(double[] x, double[] y, double targetX)
        {
            double P = 0;
            double[] L = new double[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                L[i] = 1;
                for (int j = 0; j < x.Length; j++)
                {
                    if (j == i)
                        continue;
                    L[i] *= (targetX - x[j]) / (x[i] - x[j]);
                }
            }
            for (int i = 0; i < x.Length; i++)
            {
                P += L[i] * y[i];
            }
            return P;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double[] nxValues = Array.ConvertAll(NtxtX.Text.Split(','), double.Parse);

                double[] nyValues = Array.ConvertAll(NtxtY.Text.Split(','), double.Parse);

                double nxTarget;
                double.TryParse(NtargetX.Text, out nxTarget);

                double nresult = NevilleInterpolation(nxValues, nyValues, nxTarget);

                NlabelResult.Text = $"P({nxTarget}) = {nresult}";
            }
            catch (Exception ex) { MessageBox.Show($"Error: {ex.Message}"); }
        }
        static double NevilleInterpolation(double[] x, double[] y, double targetX)
        {
            int n = x.Length;
            double[,] Q = new double[n, n];

            // Initialize Q matrix with y values
            for (int i = 0; i < n; i++)
                Q[i, 0] = y[i];

            // Neville's method
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Q[i, j] = ((targetX - x[i - j]) * Q[i, j - 1] - (targetX - x[i]) * Q[i - 1, j - 1])
                              / (x[i] - x[i - j]);
                }
            }


            return Q[n - 1, n - 1];
        }

      
    }
}
