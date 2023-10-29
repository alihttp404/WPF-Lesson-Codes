using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace command
{
    public class Car : INotifyPropertyChanged
    {
        string make;
        string model;

        public event PropertyChangedEventHandler? PropertyChanged;

        public string Make { get => make; set => make = value; }
        public string Model { get => model; set => model = value; }

        public Car()
        {
            make = "";
            model = "";
        }

        public Car(string? make, string? model)
        {
            Make = make ?? "";
            Model = model ?? "";
        }

        public override string ToString()
            => make + " " + model;

        public void OnPropertyChanged([CallerMemberName] string? propertyName = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
