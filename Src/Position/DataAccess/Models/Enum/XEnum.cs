﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
	public class XEnum
	{
		public enum WorkPlace
		{
			Any = 0,
			Well = 1,
			Ground = 2
		}
	}

    public enum PeopleCountSearchType
    {
        Region = 1,
        Department = 2,
        WorkType = 3,
        Rank = 4
    }
}
