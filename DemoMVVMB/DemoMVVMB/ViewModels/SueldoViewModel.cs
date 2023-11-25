using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DemoMVVMB.ViewModels
{
    public class SueldoViewModel : ViewModelBase
    {
        int sueldo;
        public int Sueldo
        {
            get { return sueldo; }
            set
            {
                if (sueldo != value)
                {
                    sueldo = value;
                    OnPropertyChanged();
                }
            }
        }

        int gratificacion;
        public int Gratificacion
        {
            get { return gratificacion; }
            set
            {
                if (gratificacion != value)
                {
                    gratificacion = value;
                    OnPropertyChanged();
                }
            }
        }

        //CalcularNetoFinal= SueldoNeto - Descuento
        //CalcularImpuesto= SueldoNeto * 0.08
        //Agregar 2 botones + 1 entry(Descuento)
        //Label(Mostrar Resultado)

        int sueldoNeto;
        public int SueldoNeto
        {
            get { return sueldoNeto; }
            set
            {
                if (sueldoNeto != value)
                {
                    sueldoNeto = value;
                    OnPropertyChanged();
                }
            }
        }

        //Descuento
        int descuento;
        public int Descuento
        {
            get { return descuento; }
            set
            {
                if (descuento != value)
                {
                    descuento = value;
                    OnPropertyChanged();
                }
            }
        }

        int sueldoNetoFinal;
        public int SueldoNetoFinal
        {
            get { return sueldoNetoFinal; }
            set
            {
                if (sueldoNetoFinal != value)
                {
                    sueldoNetoFinal = value;
                    OnPropertyChanged();
                }
            }
        }

        int impuesto;
        public int Impuesto
        {
            get { return impuesto; }
            set
            {
                if (impuesto != value)
                {
                    impuesto = value;
                    OnPropertyChanged();
                }
            }
        }


        public ICommand CalcularSueldoNeto { protected set; get; }
        public ICommand CalcularSueldoNetoFinal { protected set; get; }
        public ICommand CalcularImpuesto { protected set; get; }


        public SueldoViewModel() 
        {
            CalcularSueldoNeto = new Command(() =>
            {
                SueldoNeto = Sueldo + Gratificacion;
            });

            CalcularSueldoNetoFinal = new Command(() =>
            {
                SueldoNetoFinal = Sueldo + Gratificacion - Descuento;
            });

            CalcularImpuesto = new Command(() =>
            {
                Impuesto = (SueldoNeto) -(int)(SueldoNeto * 0.08);
            });
        }

    }
}
