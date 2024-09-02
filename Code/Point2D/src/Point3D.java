public class Point3D extends Point2D {
    private float z;

    public Point3D() {
        z = 0;
    }

    public Point3D(float x, float y, float z) {
        super(x, y);
        this.z = z;
    }

    public void setZ(float z) {
        this.z = z;
    }

    public float getZ() {
        return z;
    }

    public void setXYZ(float _x, float _y, float _z) {
        x = _x;
        y = _y;
        z = _z;
    }

    public float[] getXYZ() {
        float[] xyz = new float[3];
        xyz[0] = x;
        xyz[1] = y;
        xyz[2] = z;
        return xyz;
    }

    public String toString() {
        return "(" + x + "," + y + "," + z + ")";
    }
}
