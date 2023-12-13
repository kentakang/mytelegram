﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Autodownload settings
/// See <a href="https://corefork.telegram.org/constructor/autoDownloadSettings" />
///</summary>
[TlObject(0xbaa57628)]
public sealed class TAutoDownloadSettings : IAutoDownloadSettings
{
    public uint ConstructorId => 0xbaa57628;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// Disable automatic media downloads?
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool Disabled { get; set; }

    ///<summary>
    /// Whether to preload the first seconds of videos larger than the specified limit
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool VideoPreloadLarge { get; set; }

    ///<summary>
    /// Whether to preload the next audio track when you're listening to music
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool AudioPreloadNext { get; set; }

    ///<summary>
    /// Whether to enable data saving mode in phone calls
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool PhonecallsLessData { get; set; }

    ///<summary>
    /// &nbsp;
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool StoriesPreload { get; set; }

    ///<summary>
    /// Maximum size of photos to preload
    ///</summary>
    public int PhotoSizeMax { get; set; }

    ///<summary>
    /// Maximum size of videos to preload
    ///</summary>
    public long VideoSizeMax { get; set; }

    ///<summary>
    /// Maximum size of other files to preload
    ///</summary>
    public long FileSizeMax { get; set; }

    ///<summary>
    /// Maximum suggested bitrate for <strong>uploading</strong> videos
    ///</summary>
    public int VideoUploadMaxbitrate { get; set; }

    ///<summary>
    /// &nbsp;
    ///</summary>
    public int SmallQueueActiveOperationsMax { get; set; }

    ///<summary>
    /// &nbsp;
    ///</summary>
    public int LargeQueueActiveOperationsMax { get; set; }

    public void ComputeFlag()
    {
        if (Disabled) { Flags[0] = true; }
        if (VideoPreloadLarge) { Flags[1] = true; }
        if (AudioPreloadNext) { Flags[2] = true; }
        if (PhonecallsLessData) { Flags[3] = true; }
        if (StoriesPreload) { Flags[4] = true; }

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(PhotoSizeMax);
        writer.Write(VideoSizeMax);
        writer.Write(FileSizeMax);
        writer.Write(VideoUploadMaxbitrate);
        writer.Write(SmallQueueActiveOperationsMax);
        writer.Write(LargeQueueActiveOperationsMax);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[0]) { Disabled = true; }
        if (Flags[1]) { VideoPreloadLarge = true; }
        if (Flags[2]) { AudioPreloadNext = true; }
        if (Flags[3]) { PhonecallsLessData = true; }
        if (Flags[4]) { StoriesPreload = true; }
        PhotoSizeMax = reader.ReadInt32();
        VideoSizeMax = reader.ReadInt64();
        FileSizeMax = reader.ReadInt64();
        VideoUploadMaxbitrate = reader.ReadInt32();
        SmallQueueActiveOperationsMax = reader.ReadInt32();
        LargeQueueActiveOperationsMax = reader.ReadInt32();
    }
}