﻿namespace Kontenery;
using System;

public class OverfillException : Exception {

    public OverfillException(string message) : base(message) {
    }
}