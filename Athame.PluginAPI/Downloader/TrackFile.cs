﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Athame.PluginAPI.Service;

namespace Athame.PluginAPI.Downloader
{
    /// <summary>
    /// Represents the downloadable form of <see cref="Track"/>.
    /// </summary>
    public class TrackFile
    {
        /// <summary>
        /// The track this file references.
        /// </summary>
        public Track Track { get; set; }

        /// <summary>
        /// The URI to the track.
        /// </summary>
        public Uri DownloadUri { get; set; }
        /// <summary>
        /// The track's file type. This should be set using the MIME type of the track.
        /// </summary>
        public FileType FileType { get; set; }
        /// <summary>
        /// The bit rate of the track. If not known or applicable, -1.
        /// </summary>
        public int BitRate { get; set; }
    }
}
