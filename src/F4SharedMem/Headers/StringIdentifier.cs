﻿using System;

namespace F4SharedMem.Headers
{
    [Serializable]
    public enum StringIdentifier : uint
    {
        BmsExe = 0,             // BMS exe name, full path
        KeyFile,                // Key file name in use, full path

        BmsBasedir,             // BmsBasedir to BmsPictureDirectory:
        BmsBinDirectory,        // - BMS directories in use
        BmsDataDirectory,
        BmsUIArtDirectory,
        BmsUserDirectory,
        BmsAcmiDirectory,
        BmsBriefingsDirectory,
        BmsConfigDirectory,
        BmsLogsDirectory,
        BmsPatchDirectory,
        BmsPictureDirectory,

        ThrName,                 // Current theater name
        ThrCampaigndir,          // ThrCampaigndir to ThrTacrefpicsdir:
        ThrTerraindir,           // - Current theater directories in use
        ThrArtdir,
        ThrMoviedir,
        ThrUisounddir,
        ThrObjectdir,
        Thr3ddatadir,
        ThrMisctexdir,
        ThrSounddir,
        ThrTacrefdir,
        ThrSplashdir,
        ThrCockpitdir,
        ThrSimdatadir,
        ThrSubtitlesdir,
        ThrTacrefpicsdir,

        AcName,                  // Current AC name
        AcNCTR,                  // Current AC NCTR

        DrawingCommandsForHUD,  //drawing commands for HUD
        DrawingCommandsForRWR,  //drawing commands for RWR
        DrawingCommandsForHMS,  //drawing commands for HMS

        StringIdentifier_DIM     // (number of identifiers; add new IDs only *above* this one)
    };
}