
/*
3- Float class
Write a class called FloatNumber to implement the floating point number:

 * The class has two integer data members val and ndp. Where val represents the whole number 
and ndp represents the number of decimal places. For example the number 235478.67 will be 
represented as val=23547867 and ndp=2
The class has two constructors:
a) A constructor the takes two integers one of them for val and the other of ndp
b) A constructor that takes a float and deduce(تستنتج (val and ndp from it
The class has the following methods:
a) Setters and getters for val and ndp
b) Add that takes a FloatNumber(as an object) and adds it to its object and returns the 
result object
c) Addinteger that takes an integer and adds it to its object and returns the result onjec
d) Mul that takes a FloatNumber(as an object) and multipliess it to its object and returns 
the result object
e) Mulinteger that takes an integer and multiplies it to its object and returns the result 
onject
f) Round that rounds the object to the nearest integer and return the result as integer
g) Show that displays the object as a float numbe
 */
import java.lang.*;

public class FloatNumber {
    public int value;
    public int ndp;

    // Constructor
    public FloatNumber() {
        value = 0;
        ndp = 0;
    }

    public FloatNumber(int v, int n) {
        value = v;
        ndp = n;
    }

    public FloatNumber(float n) {
        while (Math.floor(n) < Math.ceil(n)) {
            n = n * 10;
            ndp++;
        }
        value = (int) n;
    }

    public FloatNumber AddFloat(FloatNumber floatNumber) {
        FloatNumber result = new FloatNumber();
        float f1;
        float f2;
        float f3;
        f1 = floatNumber.convertValue(floatNumber.value, floatNumber.ndp);
        f2 = convertValue(value, ndp);
        f3 = f1 + f2;
        while (Math.floor(f3) < Math.ceil(f3)) {
            f3 = f3 * 10;
            result.ndp++;
        }
        result.value = (int) f3;
        return result;
    }

    public float convertValue(int v, int n1) {
        float r = 0;
        while (n1 > 0) {
            r = v / 10;
            n1--;
        }
        float result = r;
        return result;
    }

}