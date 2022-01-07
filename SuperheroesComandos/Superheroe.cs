using System.Collections.Generic;
using System.ComponentModel;

namespace SuperheroesComandos
{
    class Superheroe : INotifyPropertyChanged
    {
        private string _nombre;
        public string Nombre
        {
            get => _nombre;
            set
            {
                if (_nombre != value)
                {
                    _nombre = value;
                    NotifyPropertyChanged("Nombre");
                }
            }
        }
        private string _imagen;
        public string Imagen
        {
            get => _imagen;
            set
            {
                if (_imagen != value)
                {
                    _imagen = value;
                    NotifyPropertyChanged("Imagen");
                }
            }
        }

        private bool _vengador;
        public bool Vengador
        {
            get => _vengador;
            set
            {
                if (_vengador != value)
                {
                    _vengador = value;
                    NotifyPropertyChanged("Vengador");
                }
            }
        }

        private bool _xmen;
        public bool Xmen
        {
            get => _xmen;
            set
            {
                if (_xmen != value)
                {
                    _xmen = value;
                    NotifyPropertyChanged("Xmen");
                }
            }
        }

        private bool _heroe;
        public bool Heroe
        {
            get => _heroe;
            set
            {
                if (_heroe != value)
                {
                    _heroe = value;
                    NotifyPropertyChanged("Heroe");
                }
            }
        }

        public Superheroe()
        {
        }

        public Superheroe(string nombre, string imagen, bool vengador, bool xmen, bool heroe)
        {
            Nombre = nombre;
            Imagen = imagen;
            Vengador = vengador;
            Xmen = xmen;
            Heroe = heroe;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
