﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfDesignAndAnimationLab.Common
{
    public abstract class Increaser<T> : DependencyObject
    {
        public virtual T Start { get; set; }

        public T Step { get; set; }

        public abstract T Next { get; }
    }
}
