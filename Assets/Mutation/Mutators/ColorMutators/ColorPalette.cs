// Copyright 2017 voidALPHA, Inc.
// This file is part of the Haxxis video generation system and is provided
// by voidALPHA in support of the Cyber Grand Challenge.
// Haxxis is free software: you can redistribute it and/or modify it under the terms
// of the GNU General Public License as published by the Free Software Foundation.
// Haxxis is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY;
// without even the implied warranty of MERCHANTABILITY or FITNESS FOR A
// PARTICULAR PURPOSE. See the GNU General Public License for more details.
// You should have received a copy of the GNU General Public License along with
// Haxxis. If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Mutation.Mutators.ColorMutators
{
    public class ColorPalette : MonoBehaviour
    {
        private static ColorPalette ColorPaletteMaster { get; set; }

        [SerializeField]
        private List<Color> m_ColorsList = new List<Color>();
        private List<Color> ColorsList { get { return m_ColorsList; } set { m_ColorsList = value; } }

        public void Start()
        {
            if (ColorPaletteMaster == null)
                ColorPaletteMaster = this;
        }

        public static Color ColorFromIndex(int index)
        {
            return ColorPaletteMaster.ColorsList[index%ColorPaletteMaster.ColorsList.Count];
        }
    }
}
