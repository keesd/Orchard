﻿namespace Orchard.Users.Models {
    public enum UserStatus {
        Pending,
        Approved,
        Locked,
        PasswordExpired,
        PasswordMustChange
    }
}