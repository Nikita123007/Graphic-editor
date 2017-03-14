using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using ShapeLibrary;

namespace LabaOOP
{
    public class ImportManager
    {
        [ImportMany(typeof(Shape), AllowRecomposition = false)]
        public IEnumerable<Lazy<Shape>> readerExtCollection { get; set; }
    }
}
