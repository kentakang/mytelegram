﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
/// Get highscores of a game sent using an inline bot
/// <para>Possible errors</para>
/// Code Type Description
/// 400 MESSAGE_ID_INVALID The provided message id is invalid.
/// 400 USER_BOT_REQUIRED This method can only be called by a bot.
/// See <a href="https://corefork.telegram.org/method/messages.getInlineGameHighScores" />
///</summary>
[TlObject(0xf635e1b)]
public sealed class RequestGetInlineGameHighScores : IRequest<MyTelegram.Schema.Messages.IHighScores>
{
    public uint ConstructorId => 0xf635e1b;
    ///<summary>
    /// ID of inline message
    /// See <a href="https://corefork.telegram.org/type/InputBotInlineMessageID" />
    ///</summary>
    public MyTelegram.Schema.IInputBotInlineMessageID Id { get; set; }

    ///<summary>
    /// Get high scores of a certain user
    /// See <a href="https://corefork.telegram.org/type/InputUser" />
    ///</summary>
    public MyTelegram.Schema.IInputUser UserId { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Id);
        writer.Write(UserId);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Id = reader.Read<MyTelegram.Schema.IInputBotInlineMessageID>();
        UserId = reader.Read<MyTelegram.Schema.IInputUser>();
    }
}