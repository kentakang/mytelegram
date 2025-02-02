﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
/// Edit message
/// <para>Possible errors</para>
/// Code Type Description
/// 400 BOT_DOMAIN_INVALID Bot domain invalid.
/// 400 BOT_INVALID This is not a valid bot.
/// 400 BUTTON_DATA_INVALID The data of one or more of the buttons you provided is invalid.
/// 400 BUTTON_TYPE_INVALID The type of one or more of the buttons you provided is invalid.
/// 400 BUTTON_URL_INVALID Button URL invalid.
/// 400 CHANNEL_INVALID The provided channel is invalid.
/// 406 CHANNEL_PRIVATE You haven't joined this channel/supergroup.
/// 403 CHAT_ADMIN_REQUIRED You must be an admin in this chat to do this.
/// 400 CHAT_FORWARDS_RESTRICTED You can't forward messages from a protected chat.
/// 403 CHAT_SEND_GIFS_FORBIDDEN You can't send gifs in this chat.
/// 403 CHAT_WRITE_FORBIDDEN You can't write in this chat.
/// 400 DOCUMENT_INVALID The specified document is invalid.
/// 400 ENTITIES_TOO_LONG You provided too many styled message entities.
/// 400 ENTITY_BOUNDS_INVALID A specified <a href="https://corefork.telegram.org/api/entities#entity-length">entity offset or length</a> is invalid, see <a href="https://corefork.telegram.org/api/entities#entity-length">here »</a> for info on how to properly compute the entity offset/length.
/// 400 IMAGE_PROCESS_FAILED Failure while processing image.
/// 403 INLINE_BOT_REQUIRED Only the inline bot can edit message.
/// 400 INPUT_USER_DEACTIVATED The specified user was deleted.
/// 400 MEDIA_CAPTION_TOO_LONG The caption is too long.
/// 400 MEDIA_EMPTY The provided media object is invalid.
/// 400 MEDIA_GROUPED_INVALID You tried to send media of different types in an album.
/// 400 MEDIA_NEW_INVALID The new media is invalid.
/// 400 MEDIA_PREV_INVALID Previous media invalid.
/// 400 MEDIA_TTL_INVALID The specified media TTL is invalid.
/// 403 MESSAGE_AUTHOR_REQUIRED Message author required.
/// 400 MESSAGE_EDIT_TIME_EXPIRED You can't edit this message anymore, too much time has passed since its creation.
/// 400 MESSAGE_EMPTY The provided message is empty.
/// 400 MESSAGE_ID_INVALID The provided message id is invalid.
/// 400 MESSAGE_NOT_MODIFIED The provided message data is identical to the previous message data, the message wasn't modified.
/// 400 MESSAGE_TOO_LONG The provided message is too long.
/// 400 MSG_ID_INVALID Invalid message ID provided.
/// 400 PEER_ID_INVALID The provided peer id is invalid.
/// 400 REPLY_MARKUP_INVALID The provided reply markup is invalid.
/// 400 SCHEDULE_DATE_INVALID Invalid schedule date provided.
/// 400 USER_BANNED_IN_CHANNEL You're banned from sending messages in supergroups/channels.
/// See <a href="https://corefork.telegram.org/method/messages.editMessage" />
///</summary>
[TlObject(0x48f71778)]
public sealed class RequestEditMessage : IRequest<MyTelegram.Schema.IUpdates>
{
    public uint ConstructorId => 0x48f71778;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// Disable webpage preview
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool NoWebpage { get; set; }
    public bool InvertMedia { get; set; }

    ///<summary>
    /// Where was the message sent
    /// See <a href="https://corefork.telegram.org/type/InputPeer" />
    ///</summary>
    public MyTelegram.Schema.IInputPeer Peer { get; set; }

    ///<summary>
    /// ID of the message to edit
    ///</summary>
    public int Id { get; set; }

    ///<summary>
    /// New message
    ///</summary>
    public string? Message { get; set; }

    ///<summary>
    /// New attached media
    /// See <a href="https://corefork.telegram.org/type/InputMedia" />
    ///</summary>
    public MyTelegram.Schema.IInputMedia? Media { get; set; }

    ///<summary>
    /// Reply markup for inline keyboards
    /// See <a href="https://corefork.telegram.org/type/ReplyMarkup" />
    ///</summary>
    public MyTelegram.Schema.IReplyMarkup? ReplyMarkup { get; set; }

    ///<summary>
    /// <a href="https://corefork.telegram.org/api/entities">Message entities for styled text</a>
    ///</summary>
    public TVector<MyTelegram.Schema.IMessageEntity>? Entities { get; set; }

    ///<summary>
    /// Scheduled message date for <a href="https://corefork.telegram.org/api/scheduled-messages">scheduled messages</a>
    ///</summary>
    public int? ScheduleDate { get; set; }

    public void ComputeFlag()
    {
        if (NoWebpage) { Flags[1] = true; }
        if (InvertMedia) { Flags[16] = true; }
        if (Message != null) { Flags[11] = true; }
        if (Media != null) { Flags[14] = true; }
        if (ReplyMarkup != null) { Flags[2] = true; }
        if (Entities?.Count > 0) { Flags[3] = true; }
        if (/*ScheduleDate != 0 && */ScheduleDate.HasValue) { Flags[15] = true; }
    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(Peer);
        writer.Write(Id);
        if (Flags[11]) { writer.Write(Message); }
        if (Flags[14]) { writer.Write(Media); }
        if (Flags[2]) { writer.Write(ReplyMarkup); }
        if (Flags[3]) { writer.Write(Entities); }
        if (Flags[15]) { writer.Write(ScheduleDate.Value); }
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[1]) { NoWebpage = true; }
        if (Flags[16]) { InvertMedia = true; }
        Peer = reader.Read<MyTelegram.Schema.IInputPeer>();
        Id = reader.ReadInt32();
        if (Flags[11]) { Message = reader.ReadString(); }
        if (Flags[14]) { Media = reader.Read<MyTelegram.Schema.IInputMedia>(); }
        if (Flags[2]) { ReplyMarkup = reader.Read<MyTelegram.Schema.IReplyMarkup>(); }
        if (Flags[3]) { Entities = reader.Read<TVector<MyTelegram.Schema.IMessageEntity>>(); }
        if (Flags[15]) { ScheduleDate = reader.ReadInt32(); }
    }
}
