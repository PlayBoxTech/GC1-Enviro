namespace GameCreator.Core
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;
	using UnityEngine.Events;

	[AddComponentMenu("")]
	public class Set_Time : IAction
	{
		public int hour = 7;
		public int minute = 0;
		public int year = 2020;
		// public int day_of_year = 125;
		public int month = 3;
		public int day = 5;

        private DateTime thedate;
        private int day_of_year;

        public override bool InstantExecute(GameObject target, IAction[] actions, int index)
        {
            thedate = new DateTime(year, month, day);
			day_of_year = thedate.DayOfYear;
            //Debug.Log (thedate.ToString);
            //Debug.Log (day_of_year.ToString);
            Debug.Log (day_of_year);
			EnviroSkyMgr.instance.ChangeSeason(EnviroSeasons.Seasons.Spring);
			EnviroSkyMgr.instance.SetTime(year,day_of_year,hour,minute,0);
            return true;
        }

		#if UNITY_EDITOR
        public static new string NAME = "Custom/Set_Time";
		#endif
	}
}
