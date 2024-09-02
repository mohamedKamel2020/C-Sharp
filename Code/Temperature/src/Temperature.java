
public class Temperature {
    private double fTemp;
    private double celsius;
    private double kelvin;

    public Temperature(double _ftemp) {
        fTemp = _ftemp;
        celsius = ((5 / 9) * (fTemp - 32));
        kelvin = ((5 / 9) * (fTemp - 32) + 273);
    }

    public void setFahrenheit(double _ftemp) {
        fTemp = _ftemp;
    }

    public double getFahrenheit() {
        return fTemp;
    }

    public double getCelsius() {
        return celsius;
    }

    public double getKelvin() {
        return kelvin;
    }
}
