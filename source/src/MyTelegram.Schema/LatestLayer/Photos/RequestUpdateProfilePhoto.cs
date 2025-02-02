﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Photos;

///<summary>
/// Installs a previously uploaded photo as a profile photo.
/// <para>Possible errors</para>
/// Code Type Description
/// 400 ALBUM_PHOTOS_TOO_MANY You have uploaded too many profile photos, delete some before retrying.
/// 400 FILE_PARTS_INVALID The number of file parts is invalid.
/// 500 FILE_WRITE_EMPTY &nbsp;
/// 400 IMAGE_PROCESS_FAILED Failure while processing image.
/// 400 LOCATION_INVALID The provided location is invalid.
/// 400 PHOTO_CROP_SIZE_SMALL Photo is too small.
/// 400 PHOTO_EXT_INVALID The extension of the photo is invalid.
/// 400 PHOTO_ID_INVALID Photo ID invalid.
/// See <a href="https://corefork.telegram.org/method/photos.updateProfilePhoto" />
///</summary>
[TlObject(0x9e82039)]
public sealed class RequestUpdateProfilePhoto : IRequest<MyTelegram.Schema.Photos.IPhoto>
{
    public uint ConstructorId => 0x9e82039;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// If set, the chosen profile photo will be shown to users that can't display your main profile photo due to your privacy settings.
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool Fallback { get; set; }

    ///<summary>
    /// Can contain info of a bot we own, to change the profile photo of that bot, instead of the current user.
    /// See <a href="https://corefork.telegram.org/type/InputUser" />
    ///</summary>
    public MyTelegram.Schema.IInputUser? Bot { get; set; }

    ///<summary>
    /// Input photo
    /// See <a href="https://corefork.telegram.org/type/InputPhoto" />
    ///</summary>
    public MyTelegram.Schema.IInputPhoto Id { get; set; }

    public void ComputeFlag()
    {
        if (Fallback) { Flags[0] = true; }
        if (Bot != null) { Flags[1] = true; }

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        if (Flags[1]) { writer.Write(Bot); }
        writer.Write(Id);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[0]) { Fallback = true; }
        if (Flags[1]) { Bot = reader.Read<MyTelegram.Schema.IInputUser>(); }
        Id = reader.Read<MyTelegram.Schema.IInputPhoto>();
    }
}
