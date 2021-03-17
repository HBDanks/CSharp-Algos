public class Solution {
    
    double radius;
    double xCenter;
    double yCenter;

    public Solution(double _radius, double x_center, double y_center) {
        radius = _radius;
        xCenter = x_center;
        yCenter = y_center;
    }
    
    // Uniformly generates random points in a circle, given the center and radius
    public double[] RandPoint() {
        var rand = new Random();
        double angle = rand.NextDouble()*2*Math.PI;
        // The problem asks for a uniform distribution of points so:
        // we do the square root here to bias the points toward the sections of the circle where there is more area,
        // this is not necessary to randomly generate points in the circle
        double rad = Math.Sqrt(rand.NextDouble())*radius;
        double randX = rad*Math.Cos(angle)+xCenter;
        double randY = rad*Math.Sin(angle)+yCenter;
        Console.WriteLine($"Radius: {rad}, X: {randX}, Y: {randY}");
        return new double[]{randX, randY};
    }
}