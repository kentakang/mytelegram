﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Phone;

///<summary>
/// Join a group call
/// <para>Possible errors</para>
/// Code Type Description
/// 400 DATA_JSON_INVALID The provided JSON data is invalid.
/// 403 GROUPCALL_FORBIDDEN The group call has already ended.
/// 400 GROUPCALL_INVALID The specified group call is invalid.
/// 400 GROUPCALL_SSRC_DUPLICATE_MUCH The app needs to retry joining the group call with a new SSRC value.
/// 400 JOIN_AS_PEER_INVALID The specified peer cannot be used to join a group call.
/// See <a href="https://corefork.telegram.org/method/phone.joinGroupCall" />
///</summary>
[TlObject(0xb132ff7b)]
public sealed class RequestJoinGroupCall : IRequest<MyTelegram.Schema.IUpdates>
{
    public uint ConstructorId => 0xb132ff7b;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// If set, the user will be muted by default upon joining.
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool Muted { get; set; }

    ///<summary>
    /// If set, the user's video will be disabled by default upon joining.
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool VideoStopped { get; set; }

    ///<summary>
    /// The group call
    /// See <a href="https://corefork.telegram.org/type/InputGroupCall" />
    ///</summary>
    public MyTelegram.Schema.IInputGroupCall Call { get; set; }

    ///<summary>
    /// Join the group call, presenting yourself as the specified user/channel
    /// See <a href="https://corefork.telegram.org/type/InputPeer" />
    ///</summary>
    public MyTelegram.Schema.IInputPeer JoinAs { get; set; }

    ///<summary>
    /// The invitation hash from the <a href="https://corefork.telegram.org/api/links#video-chat-livestream-links">invite link »</a>, if provided allows speaking in a livestream or muted group chat.
    ///</summary>
    public string? InviteHash { get; set; }

    ///<summary>
    /// WebRTC parameters
    /// See <a href="https://corefork.telegram.org/type/DataJSON" />
    ///</summary>
    public MyTelegram.Schema.IDataJSON Params { get; set; }

    public void ComputeFlag()
    {
        if (Muted) { Flags[0] = true; }
        if (VideoStopped) { Flags[2] = true; }
        if (InviteHash != null) { Flags[1] = true; }

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(Call);
        writer.Write(JoinAs);
        if (Flags[1]) { writer.Write(InviteHash); }
        writer.Write(Params);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[0]) { Muted = true; }
        if (Flags[2]) { VideoStopped = true; }
        Call = reader.Read<MyTelegram.Schema.IInputGroupCall>();
        JoinAs = reader.Read<MyTelegram.Schema.IInputPeer>();
        if (Flags[1]) { InviteHash = reader.ReadString(); }
        Params = reader.Read<MyTelegram.Schema.IDataJSON>();
    }
}