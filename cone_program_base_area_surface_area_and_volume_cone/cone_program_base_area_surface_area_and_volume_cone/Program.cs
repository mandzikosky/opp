// See https://aka.ms/new-console-template for more information

using cone_program_base_area_surface_area_and_volume_cone;

Cone cone = new Cone();
Console.WriteLine("Please insert the height and radius from Cone: ");
double height =Convert.ToDouble(Console.ReadLine());
double radius = Convert.ToDouble(Console.ReadLine());
double baseArea=cone.CalculatingBase(height, radius);
Console.WriteLine("Base Area of the Cone is: "+ baseArea);
double  surfaceArea=cone.CalculatingSurface(height, radius);
Console.WriteLine("Surface Area od the Cone is: "+surfaceArea);
double volumeArea=cone.CalculatingVolume(height, radius);
Console.WriteLine("Volume Area of Cone is: "+volumeArea);






