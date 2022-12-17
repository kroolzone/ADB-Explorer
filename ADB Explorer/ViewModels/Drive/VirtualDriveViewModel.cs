﻿using ADB_Explorer.Models;

namespace ADB_Explorer.ViewModels;

class VirtualDriveViewModel : DriveViewModel
{
    private VirtualDrive drive;
    protected new VirtualDrive Drive
    {
        get => drive;
        set => Set(ref drive, value);
    }

    public ulong ItemsCount => Drive.ItemsCount;

    
    public VirtualDriveViewModel(VirtualDrive drive) : base(drive)
    {
        Drive = drive;
    }

    public void SetItemsCount(int count) => SetItemsCount((ulong)count);

    public void SetItemsCount(ulong newCount)
    {
        if (Drive.ItemsCount != newCount)
        {
            Drive.ItemsCount = newCount;
            OnPropertyChanged(nameof(ItemsCount));
        }
    }

    public override string ToString() => $"{Type}";
}
