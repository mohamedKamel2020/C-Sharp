using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_01
{
    public class Car
    {
		#region Attributes
		private int id;
		private string model;
		private double currentSpead;

		#endregion

		#region Getter Setter
		public double CurrenSpead
		{
			get { return currentSpead; }
			set { currentSpead = value; }
		}


		public string Model
		{
			get { return model; }
			set { model = value; }
		}

		public int Id
		{
			get { return id; }
			set { id = value; }
		}
		#endregion

		#region Constructor

		public Car(int _id,string _model,double _currenSpead)
		{
			id= _id;
			model= _model;
			currentSpead = _currenSpead;
		}
        public Car(int _id,string _model):this( _id,_model,300)
        {
            
        }
        public Car(int _id):this(_id, "Jeep")
        {
            
        }
        #endregion

        #region Methods

        public override string ToString()
		{
			return $"{id} :: {model} :: {currentSpead}";
		} 
		#endregion

	}
}
