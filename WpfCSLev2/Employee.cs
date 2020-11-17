using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfCSLev2
{
    public class Employee : INotifyPropertyChanged
    {
        private int _id;
        private string _name;
        private string _surname;
        private string _patronymic;
        private DateTime _birthday;
        private byte _age;
        private float _salary;
        public int Id
        {
            get => _id;
            set
            {
                _id = value;
                OnPropertyChanged();
            }
        }
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }
        public string Surname
        {
            get => _surname;
            set
            {
                _surname = value;
                OnPropertyChanged();
            }
        }
        public string Patronymic
        {
            get => _patronymic;
            set
            {
                _patronymic = value;
                OnPropertyChanged();
            }
        }
        public DateTime Birthday
        {
            get => _birthday;
            set
            {
                _birthday = value;
                OnPropertyChanged();
            }
        }
        public byte Age
        {
            get => _age;
            set
            {
                _age = value;
                OnPropertyChanged();
            }
        }
        public float Salary
        {
            get => _salary;
            set
            {
                _salary = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
