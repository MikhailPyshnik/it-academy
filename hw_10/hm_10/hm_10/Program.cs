using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Config;

namespace hm_10
{
    class Program
    {
      //  public static readonly ILog log = LogManager.GetLogger(typeof(Program));

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
      (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
           // DOMConfigurator.Configure();
            log4net.Config.BasicConfigurator.Configure();
           ILog log = log4net.LogManager.GetLogger(typeof(Program));

            double EnteredRadius = 1;
            double SemiPerimeter = 1.25;

            log.Info("Начался процесс создания/инициализации массива фигур");

            Figurecs[] figures = { new Square(EnteredRadius, SemiPerimeter), new Сircle(EnteredRadius, SemiPerimeter), new IsoscelesTriangle(EnteredRadius, SemiPerimeter) };

            foreach (var item in figures)
            {
                for (int i = 0; i < 10; i++)
                {
                    log.Info("Начался процесс расчета площади фигуры");
                    item.PrintAreaFigure(item.AreaFigure(EnteredRadius, SemiPerimeter));
                    EnteredRadius++;
                    SemiPerimeter++;
                }
                EnteredRadius = 1;
                SemiPerimeter = 1.25;
            }
            log.Info("Программа успешна завершена");
            Console.ReadLine();
        }

        class Square : Figurecs, IСountArea
        {
            public Square(double aEnteredRadius, double aSemiPerimeter)
            {
                FigureName = "Square";
                EnteredRadius = aEnteredRadius;
                SemiPerimeter = aSemiPerimeter;
            }

            public override double AreaFigure(double EnteredRadius, double SemiPerimeter)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                FigureArea = EnteredRadius * EnteredRadius;
                return FigureArea;
            }

            public void PrintAreaFigure()
            {
            }
        }

        class Сircle : Figurecs, IСountArea
        {
            public Сircle(double aEnteredRadius, double aSemiPerimeter)
            {
                FigureName = "Сircle";
                EnteredRadius = aEnteredRadius;
                SemiPerimeter = aSemiPerimeter;
            }

             public override double AreaFigure(double EnteredRadius, double SemiPerimeter)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                FigureArea = EnteredRadius * EnteredRadius * Pi;
                return FigureArea;
            }

            public void PrintAreaFigure()
            {
            }

        }

        class IsoscelesTriangle: Figurecs, IСountArea
        {
            public IsoscelesTriangle(double aEnteredRadius, double aSemiPerimeter)
            {
                FigureName = "IsoscelesTriangle";
                EnteredRadius = aEnteredRadius;
                SemiPerimeter = aSemiPerimeter;
            }

            public override double AreaFigure(double EnteredRadius, double SemiPerimeter)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                FigureArea = EnteredRadius * SemiPerimeter;
                return FigureArea;
            }

            public void PrintAreaFigure()
            {
            }
        }
    }
}
