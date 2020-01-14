﻿using System;
using System.Runtime.InteropServices;

public class Colour
{
    //ESCAPE CODES FOR COLOUR
    //public const string BOLD = "\u001B[1m";
    public const string NAME = "\u001b[38;5;14m";
    //public const string BLOOD = "\u001b[38;5;124m";
    public const string TEAM = "\u001b[38;5;172m";
    public const string POSITION = "\u001b[38;5;33m";
    //public const string CLASS = "\u001b[38;5;5m";
    public const string SECONDARY = "\u001b[38;5;11m";
    //public const string STUNNED = "\u001b[30;1m";
    public const string PRICE = "\u001b[38;5;136m";
    public const string GOAL = "\u001b[38;5;118m";
    public const string SHOOT = "\u001b[38;5;2m";
    public const string PENALTY = "\u001b[38;5;33m";
    public const string INJURY = "\u001b[38;5;160m";
    public const string FIGHT = "\u001b[38;5;204m";
    //public const string BOSS = "\u001b[38;5;124m";
    //public const string MITIGATION = "\u001b[38;5;241m";
    public const string SPEAK = "\u001b[38;5;230m";
    public const string PASS = "\u001b[38;5;80m";
    public const string OVERALL = "\u001b[38;5;164m";
    //public const string DROP = "\u001b[38;5;58m";
    //public const string RAREDROP = "\u001b[38;5;127m";
    //public const string ENHANCEMENT = "\u001b[38;5;170m";
    public const string ASSIST = "\u001b[38;5;50m";
    //public const string SPECIAL = "\u001b[38;5;89m";
    //public const string HIT = "\u001b[38;5;142m";
    public const string SPEED = "\u001b[38;5;167m";
    //public const string DEFENCE = "\u001b[38;5;189m";
    public const string RESET = "\u001B[1m\u001B[37m";


    const int STD_OUTPUT_HANDLE = -11;
    const uint ENABLE_VIRTUAL_TERMINAL_PROCESSING = 4;
    [DllImport("kernel32.dll", SetLastError = true)]
    static extern IntPtr GetStdHandle(int nStdHandle);
    [DllImport("kernel32.dll")]
    static extern bool GetConsoleMode(IntPtr hConsoleHandle, out uint lpMode);
    [DllImport("kernel32.dll")]
    static extern bool SetConsoleMode(IntPtr hConsoleHandle, uint dwMode);

    public static void SetupConsole()
    {
        IntPtr handle = GetStdHandle(STD_OUTPUT_HANDLE);
        uint mode;
        GetConsoleMode(handle, out mode);
        mode |= ENABLE_VIRTUAL_TERMINAL_PROCESSING;
        SetConsoleMode(handle, mode);
    }
}