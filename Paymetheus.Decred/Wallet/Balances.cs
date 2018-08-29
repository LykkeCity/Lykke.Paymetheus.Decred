﻿// Copyright (c) 2016 The Decred developers
// Licensed under the ISC license.  See LICENSE file in the project root for full license information.

namespace Paymetheus.Decred.Wallet
{
    public struct Balances
    {
        public Balances(Amount total, Amount spendable, Amount locked)
        {
            TotalBalance = total;
            SpendableBalance = spendable;
            LockedBalance = locked;
        }

        public Amount TotalBalance { get; internal set; }
        public Amount SpendableBalance { get; internal set; }
        public Amount LockedBalance { get; internal set; }
    }
}
