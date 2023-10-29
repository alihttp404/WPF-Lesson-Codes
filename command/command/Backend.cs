using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace command
{
    public class Backend : INotifyPropertyChanged
    {
        public ObservableCollection<Car> Cars { get; set; }
        
        public event PropertyChangedEventHandler? PropertyChanged;
        public ICommand SaveCommand { get; set; }

        private Car _car;
        public Car car { get => _car; set => _car = value; }

        public Backend()
        {
            Cars = new ObservableCollection<Car>()
            {
                new Car("Lifan", "NAZ"),
                new Car("Khazar", "LX"),
                new Car("Rolls Royce", "Phantom")
            };

            SaveCommand = new RelayCommand(Save, CanSave);
            car = new Car();
        }

        public bool CanSave(object? obj)
            => (car.Make.Length > 0 && car.Model.Length > 0);

        public void Save(object? obj)
        {
            if (CanSave(obj)) 
            {
                Cars.Add(car);
                car = new Car();
                car.Make = "";
                car.Model = "";
            }
        }

        public void OnPropertyChanged([CallerMemberName] string? propertyName = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
