﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

namespace Iot.Device.Bno055
{
    /// <summary>
    /// Calibration status contains every variation from 00 to 11
    /// for every sensor. The most interesting one is full success
    /// don't try to measure full success for all 4 elements at the same time
    /// The magnetometer is the one to really wait for calibration.
    /// Calibration is done automatically by the system
    /// </summary>
    [Flags]
    public enum CalibrationStatus
    {
        MagnetometerSuccess = 0b0000_0011,
        AccelerometerSuccess = 0b0000_1100,
        GyroscopeSuccess = 0b0011_0000,
        SystemSuccess = 0b1100_0000,

    }
}
