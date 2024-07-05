class Program
{
    static void Main()
    {
        var listaAlumnos = new List<Estudiante>
        {
            new Estudiante { Nombre = "Julia", Edad = 20, Nota = 8.5 },
            new Estudiante { Nombre = "Adrián", Edad = 22, Nota = 7.0 },
            new Estudiante { Nombre = "Lucía", Edad = 19, Nota = 9.2 },
            new Estudiante { Nombre = "Víctor", Edad = 21, Nota = 6.8 },
            new Estudiante { Nombre = "Natalia", Edad = 23, Nota = 8.0 }
        };

        var listaAlumnosMayores = FiltrarAlumnosMayores(listaAlumnos, 18);

        Estudiante mejorAlumno = EncontrarMejorAlumno(listaAlumnos);

        double promedioNotas = CalcularPromedioNotas(listaAlumnos);

        MostrarAlumnosMayores(listaAlumnosMayores);
        MostrarMejorAlumno(mejorAlumno);
        MostrarPromedio(promedioNotas);
    }

    static List<Estudiante> FiltrarAlumnosMayores(List<Estudiante> alumnos, int edadMinima)
    {
        var alumnosMayores = new List<Estudiante>();
        foreach (var alumno in alumnos)
        {
            if (alumno.Edad > edadMinima)
            {
                alumnosMayores.Add(alumno);
            }
        }
        return alumnosMayores;
    }

    static Estudiante EncontrarMejorAlumno(List<Estudiante> alumnos)
    {
        Estudiante mejorAlumno = null;
        foreach (var alumno in alumnos)
        {
            if (mejorAlumno == null || alumno.Nota > mejorAlumno.Nota)
            {
                mejorAlumno = alumno;
            }
        }
        return mejorAlumno;
    }

    static double CalcularPromedioNotas(List<Estudiante> alumnos)
    {
        double sumaNotas = 0;
        foreach (var alumno in alumnos)
        {
            sumaNotas += alumno.Nota;
        }
        return sumaNotas / alumnos.Count;
    }

    static void MostrarAlumnosMayores(List<Estudiante> alumnos)
    {
        Console.WriteLine("Lista de alumnos mayores de 18 años:");
        foreach (var alumno in alumnos)
        {
            Console.WriteLine($"Nombre: {alumno.Nombre}, Nota: {alumno.Nota}");
        }
    }

    static void MostrarMejorAlumno(Estudiante alumno)
    {
        Console.WriteLine($"Mejor alumno: {alumno.Nombre} ({alumno.Nota})");
    }

    static void MostrarPromedio(double promedio)
    {
        Console.WriteLine($"Promedio de notas: {promedio}");
    }
}

// Definición de la clase Estudiante
class Estudiante
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public double Nota { get; set; }
}
