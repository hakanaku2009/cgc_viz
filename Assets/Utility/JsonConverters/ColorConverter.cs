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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UnityEngine;

namespace Utility.JsonConverters
{
    public class ColorConverter : JsonConverter
    {
        public override void WriteJson( JsonWriter writer, object value, JsonSerializer serializer )
        {
            var color = (Color)value;
            writer.WriteStartObject();
            writer.WritePropertyName( "r" );
            writer.WriteValue( color.r );
            writer.WritePropertyName( "g" );
            writer.WriteValue( color.g );
            writer.WritePropertyName( "b" );
            writer.WriteValue( color.b );
            writer.WritePropertyName( "a" );
            writer.WriteValue( color.a );
            writer.WriteEndObject();
        }

        public override object ReadJson( JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer )
        {
            throw new NotImplementedException( "Unnecessary because CanRead is false. The type will skip the converter." );
        }

        public override bool CanRead
        {
            get { return false; }
        }

        public override bool CanConvert( Type objectType )
        {
            return objectType == typeof( Color );
        }
    }
}
