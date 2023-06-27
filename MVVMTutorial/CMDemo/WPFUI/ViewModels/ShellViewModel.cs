using Caliburn.Micro;
using System;
using WPFUI.Models;

namespace WPFUI.ViewModels
{
    public class ShellViewModel : Conductor<Object>
    {
		private string _firstName = string.Empty;
		private string _lastName = string.Empty;
		private BindableCollection<PersonModel> _people = new BindableCollection<PersonModel>();
		private PersonModel _selectedPerson;

        public ShellViewModel()
        {
            People.Add(new PersonModel { FirstName = "Roy", LastName = "Padilla" });
            People.Add(new PersonModel { FirstName = "Jafeth", LastName = "Padilla" });
            People.Add(new PersonModel { FirstName = "Vanessa", LastName = "Calderon" });
        }
        public string FirstName
        {
			get { return _firstName; }
			set { 
				_firstName = value; 
				NotifyOfPropertyChange(() => FirstName);
                NotifyOfPropertyChange(() => FullName);
            }
		}

		public string LastName
		{
			get { return _lastName; }
			set { 
				_lastName = value; 
				NotifyOfPropertyChange(() => LastName);
                NotifyOfPropertyChange(() => FullName);
            }
		}

		public string FullName
		{
			get { return $"{FirstName} {LastName}"; }
			
		}

		public BindableCollection<PersonModel> People
		{
			get { return _people; }
			set { _people = value; }
		}

		public PersonModel SelectedPerson
		{
			get { return _selectedPerson; }
			set { 
				_selectedPerson = value; 
				NotifyOfPropertyChange(() => SelectedPerson);
			}
		}

		public bool CanClearText(string firstName, string lastName)// => !String.IsNullOrWhiteSpace(firstName) && !String.IsNullOrWhiteSpace(lastName);
		{
			if (String.IsNullOrWhiteSpace(firstName) && String.IsNullOrWhiteSpace(lastName))
			{
				return false;
			}
			return true;
		}
		public void ClearText(string firstName, string lastName)
		{
			FirstName = string.Empty;
			LastName = string.Empty;
		}
	
		public void LoadPageOne()
		{
			ActivateItem(new FirstChildViewModel());
		}

		public void LoadPageTwo()
		{
			ActivateItem(new SecondChildViewModel());
		}
	}
}
