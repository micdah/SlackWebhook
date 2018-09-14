<a name='assembly'></a>
# SlackWebhook

## Contents

- [ActionStyle](#T-SlackWebhook-Enums-ActionStyle 'SlackWebhook.Enums.ActionStyle')
  - [Danger](#F-SlackWebhook-Enums-ActionStyle-Danger 'SlackWebhook.Enums.ActionStyle.Danger')
  - [Primary](#F-SlackWebhook-Enums-ActionStyle-Primary 'SlackWebhook.Enums.ActionStyle.Primary')
- [ActionStyleJsonConverter](#T-SlackWebhook-Core-ActionStyleJsonConverter 'SlackWebhook.Core.ActionStyleJsonConverter')
  - [ReadJson()](#M-SlackWebhook-Core-ActionStyleJsonConverter-ReadJson-Newtonsoft-Json-JsonReader,System-Type,System-Nullable{SlackWebhook-Enums-ActionStyle},System-Boolean,Newtonsoft-Json-JsonSerializer- 'SlackWebhook.Core.ActionStyleJsonConverter.ReadJson(Newtonsoft.Json.JsonReader,System.Type,System.Nullable{SlackWebhook.Enums.ActionStyle},System.Boolean,Newtonsoft.Json.JsonSerializer)')
  - [WriteJson()](#M-SlackWebhook-Core-ActionStyleJsonConverter-WriteJson-Newtonsoft-Json-JsonWriter,System-Nullable{SlackWebhook-Enums-ActionStyle},Newtonsoft-Json-JsonSerializer- 'SlackWebhook.Core.ActionStyleJsonConverter.WriteJson(Newtonsoft.Json.JsonWriter,System.Nullable{SlackWebhook.Enums.ActionStyle},Newtonsoft.Json.JsonSerializer)')
- [FormattedTextEncoder](#T-SlackWebhook-Core-FormattedTextEncoder 'SlackWebhook.Core.FormattedTextEncoder')
- [ICloneable\`1](#T-SlackWebhook-Core-ICloneable`1 'SlackWebhook.Core.ICloneable`1')
  - [Clone()](#M-SlackWebhook-Core-ICloneable`1-Clone 'SlackWebhook.Core.ICloneable`1.Clone')
- [IconType](#T-SlackWebhook-Enums-IconType 'SlackWebhook.Enums.IconType')
  - [Emoji](#F-SlackWebhook-Enums-IconType-Emoji 'SlackWebhook.Enums.IconType.Emoji')
  - [Url](#F-SlackWebhook-Enums-IconType-Url 'SlackWebhook.Enums.IconType.Url')
- [ISlackAttachmentBuilder](#T-SlackWebhook-ISlackAttachmentBuilder 'SlackWebhook.ISlackAttachmentBuilder')
  - [WithAuthor(name,linkUrl,iconUrl)](#M-SlackWebhook-ISlackAttachmentBuilder-WithAuthor-System-String,System-String,System-String- 'SlackWebhook.ISlackAttachmentBuilder.WithAuthor(System.String,System.String,System.String)')
  - [WithColor(hexColor)](#M-SlackWebhook-ISlackAttachmentBuilder-WithColor-System-String- 'SlackWebhook.ISlackAttachmentBuilder.WithColor(System.String)')
  - [WithColor(color)](#M-SlackWebhook-ISlackAttachmentBuilder-WithColor-System-Drawing-Color- 'SlackWebhook.ISlackAttachmentBuilder.WithColor(System.Drawing.Color)')
  - [WithFallback(fallback)](#M-SlackWebhook-ISlackAttachmentBuilder-WithFallback-System-String- 'SlackWebhook.ISlackAttachmentBuilder.WithFallback(System.String)')
  - [WithField(title,value,isShort,enableFormatting)](#M-SlackWebhook-ISlackAttachmentBuilder-WithField-System-String,System-String,System-Boolean,System-Boolean- 'SlackWebhook.ISlackAttachmentBuilder.WithField(System.String,System.String,System.Boolean,System.Boolean)')
  - [WithFooter(text,iconUrl)](#M-SlackWebhook-ISlackAttachmentBuilder-WithFooter-System-String,System-String- 'SlackWebhook.ISlackAttachmentBuilder.WithFooter(System.String,System.String)')
  - [WithImage(url)](#M-SlackWebhook-ISlackAttachmentBuilder-WithImage-System-String- 'SlackWebhook.ISlackAttachmentBuilder.WithImage(System.String)')
  - [WithLink(url)](#M-SlackWebhook-ISlackAttachmentBuilder-WithLink-System-String- 'SlackWebhook.ISlackAttachmentBuilder.WithLink(System.String)')
  - [WithLinkButtonAction(text,url,style)](#M-SlackWebhook-ISlackAttachmentBuilder-WithLinkButtonAction-System-String,System-String,System-Nullable{SlackWebhook-Enums-ActionStyle}- 'SlackWebhook.ISlackAttachmentBuilder.WithLinkButtonAction(System.String,System.String,System.Nullable{SlackWebhook.Enums.ActionStyle})')
  - [WithPreText(text,enableFormatting)](#M-SlackWebhook-ISlackAttachmentBuilder-WithPreText-System-String,System-Boolean- 'SlackWebhook.ISlackAttachmentBuilder.WithPreText(System.String,System.Boolean)')
  - [WithText(text,enableFormatting)](#M-SlackWebhook-ISlackAttachmentBuilder-WithText-System-String,System-Boolean- 'SlackWebhook.ISlackAttachmentBuilder.WithText(System.String,System.Boolean)')
  - [WithThumbnail(url)](#M-SlackWebhook-ISlackAttachmentBuilder-WithThumbnail-System-String- 'SlackWebhook.ISlackAttachmentBuilder.WithThumbnail(System.String)')
  - [WithTimestamp(timestamp)](#M-SlackWebhook-ISlackAttachmentBuilder-WithTimestamp-System-DateTimeOffset- 'SlackWebhook.ISlackAttachmentBuilder.WithTimestamp(System.DateTimeOffset)')
  - [WithTimestamp(epochTime)](#M-SlackWebhook-ISlackAttachmentBuilder-WithTimestamp-System-Int32- 'SlackWebhook.ISlackAttachmentBuilder.WithTimestamp(System.Int32)')
  - [WithTitle(title)](#M-SlackWebhook-ISlackAttachmentBuilder-WithTitle-System-String- 'SlackWebhook.ISlackAttachmentBuilder.WithTitle(System.String)')
- [ISlackClient](#T-SlackWebhook-ISlackClient 'SlackWebhook.ISlackClient')
  - [SendAsync(configureBuilder)](#M-SlackWebhook-ISlackClient-SendAsync-System-Action{SlackWebhook-ISlackMessageBuilder}- 'SlackWebhook.ISlackClient.SendAsync(System.Action{SlackWebhook.ISlackMessageBuilder})')
  - [SendAsync(message)](#M-SlackWebhook-ISlackClient-SendAsync-SlackWebhook-Messages-SlackMessage- 'SlackWebhook.ISlackClient.SendAsync(SlackWebhook.Messages.SlackMessage)')
- [ISlackMessageBuilder](#T-SlackWebhook-ISlackMessageBuilder 'SlackWebhook.ISlackMessageBuilder')
  - [Build()](#M-SlackWebhook-ISlackMessageBuilder-Build 'SlackWebhook.ISlackMessageBuilder.Build')
  - [WithAttachment(configureAttachment)](#M-SlackWebhook-ISlackMessageBuilder-WithAttachment-System-Action{SlackWebhook-ISlackAttachmentBuilder}- 'SlackWebhook.ISlackMessageBuilder.WithAttachment(System.Action{SlackWebhook.ISlackAttachmentBuilder})')
  - [WithChannel(channel)](#M-SlackWebhook-ISlackMessageBuilder-WithChannel-System-String- 'SlackWebhook.ISlackMessageBuilder.WithChannel(System.String)')
  - [WithIcon(iconType,urlOrEmoji)](#M-SlackWebhook-ISlackMessageBuilder-WithIcon-SlackWebhook-Enums-IconType,System-String- 'SlackWebhook.ISlackMessageBuilder.WithIcon(SlackWebhook.Enums.IconType,System.String)')
  - [WithText(text,enableFormatting)](#M-SlackWebhook-ISlackMessageBuilder-WithText-System-String,System-Boolean- 'SlackWebhook.ISlackMessageBuilder.WithText(System.String,System.Boolean)')
  - [WithUsername(username)](#M-SlackWebhook-ISlackMessageBuilder-WithUsername-System-String- 'SlackWebhook.ISlackMessageBuilder.WithUsername(System.String)')
- [IValidateable](#T-SlackWebhook-Core-IValidateable 'SlackWebhook.Core.IValidateable')
  - [Validate(validationErrors)](#M-SlackWebhook-Core-IValidateable-Validate-System-Collections-Generic-ICollection{SlackWebhook-Exceptions-ValidationError}@- 'SlackWebhook.Core.IValidateable.Validate(System.Collections.Generic.ICollection{SlackWebhook.Exceptions.ValidationError}@)')
- [SlackAttachment](#T-SlackWebhook-Messages-SlackAttachment 'SlackWebhook.Messages.SlackAttachment')
  - [FormattingFields](#F-SlackWebhook-Messages-SlackAttachment-FormattingFields 'SlackWebhook.Messages.SlackAttachment.FormattingFields')
  - [FormattingPretext](#F-SlackWebhook-Messages-SlackAttachment-FormattingPretext 'SlackWebhook.Messages.SlackAttachment.FormattingPretext')
  - [FormattingText](#F-SlackWebhook-Messages-SlackAttachment-FormattingText 'SlackWebhook.Messages.SlackAttachment.FormattingText')
  - [Actions](#P-SlackWebhook-Messages-SlackAttachment-Actions 'SlackWebhook.Messages.SlackAttachment.Actions')
  - [AuthorIcon](#P-SlackWebhook-Messages-SlackAttachment-AuthorIcon 'SlackWebhook.Messages.SlackAttachment.AuthorIcon')
  - [AuthorLink](#P-SlackWebhook-Messages-SlackAttachment-AuthorLink 'SlackWebhook.Messages.SlackAttachment.AuthorLink')
  - [AuthorName](#P-SlackWebhook-Messages-SlackAttachment-AuthorName 'SlackWebhook.Messages.SlackAttachment.AuthorName')
  - [Color](#P-SlackWebhook-Messages-SlackAttachment-Color 'SlackWebhook.Messages.SlackAttachment.Color')
  - [EnableFormatting](#P-SlackWebhook-Messages-SlackAttachment-EnableFormatting 'SlackWebhook.Messages.SlackAttachment.EnableFormatting')
  - [Fallback](#P-SlackWebhook-Messages-SlackAttachment-Fallback 'SlackWebhook.Messages.SlackAttachment.Fallback')
  - [Fields](#P-SlackWebhook-Messages-SlackAttachment-Fields 'SlackWebhook.Messages.SlackAttachment.Fields')
  - [Footer](#P-SlackWebhook-Messages-SlackAttachment-Footer 'SlackWebhook.Messages.SlackAttachment.Footer')
  - [FooterIcon](#P-SlackWebhook-Messages-SlackAttachment-FooterIcon 'SlackWebhook.Messages.SlackAttachment.FooterIcon')
  - [ImageUrl](#P-SlackWebhook-Messages-SlackAttachment-ImageUrl 'SlackWebhook.Messages.SlackAttachment.ImageUrl')
  - [PreText](#P-SlackWebhook-Messages-SlackAttachment-PreText 'SlackWebhook.Messages.SlackAttachment.PreText')
  - [Text](#P-SlackWebhook-Messages-SlackAttachment-Text 'SlackWebhook.Messages.SlackAttachment.Text')
  - [ThumbnailUrl](#P-SlackWebhook-Messages-SlackAttachment-ThumbnailUrl 'SlackWebhook.Messages.SlackAttachment.ThumbnailUrl')
  - [Timestamp](#P-SlackWebhook-Messages-SlackAttachment-Timestamp 'SlackWebhook.Messages.SlackAttachment.Timestamp')
  - [Title](#P-SlackWebhook-Messages-SlackAttachment-Title 'SlackWebhook.Messages.SlackAttachment.Title')
  - [TitleLink](#P-SlackWebhook-Messages-SlackAttachment-TitleLink 'SlackWebhook.Messages.SlackAttachment.TitleLink')
  - [Clone()](#M-SlackWebhook-Messages-SlackAttachment-Clone 'SlackWebhook.Messages.SlackAttachment.Clone')
  - [SetColor(color)](#M-SlackWebhook-Messages-SlackAttachment-SetColor-System-Drawing-Color- 'SlackWebhook.Messages.SlackAttachment.SetColor(System.Drawing.Color)')
  - [SetTimestamp(timestamp)](#M-SlackWebhook-Messages-SlackAttachment-SetTimestamp-System-DateTimeOffset- 'SlackWebhook.Messages.SlackAttachment.SetTimestamp(System.DateTimeOffset)')
  - [Validate()](#M-SlackWebhook-Messages-SlackAttachment-Validate-System-Collections-Generic-ICollection{SlackWebhook-Exceptions-ValidationError}@- 'SlackWebhook.Messages.SlackAttachment.Validate(System.Collections.Generic.ICollection{SlackWebhook.Exceptions.ValidationError}@)')
- [SlackAttachmentAction](#T-SlackWebhook-Messages-SlackAttachmentAction 'SlackWebhook.Messages.SlackAttachmentAction')
  - [#ctor(type)](#M-SlackWebhook-Messages-SlackAttachmentAction-#ctor-System-String- 'SlackWebhook.Messages.SlackAttachmentAction.#ctor(System.String)')
  - [Text](#P-SlackWebhook-Messages-SlackAttachmentAction-Text 'SlackWebhook.Messages.SlackAttachmentAction.Text')
  - [Type](#P-SlackWebhook-Messages-SlackAttachmentAction-Type 'SlackWebhook.Messages.SlackAttachmentAction.Type')
  - [Clone()](#M-SlackWebhook-Messages-SlackAttachmentAction-Clone 'SlackWebhook.Messages.SlackAttachmentAction.Clone')
  - [Validate()](#M-SlackWebhook-Messages-SlackAttachmentAction-Validate-System-Collections-Generic-ICollection{SlackWebhook-Exceptions-ValidationError}@- 'SlackWebhook.Messages.SlackAttachmentAction.Validate(System.Collections.Generic.ICollection{SlackWebhook.Exceptions.ValidationError}@)')
- [SlackAttachmentBuilder](#T-SlackWebhook-SlackAttachmentBuilder 'SlackWebhook.SlackAttachmentBuilder')
  - [SetEnableFormatting(formattingType,enable)](#M-SlackWebhook-SlackAttachmentBuilder-SetEnableFormatting-System-String,System-Boolean- 'SlackWebhook.SlackAttachmentBuilder.SetEnableFormatting(System.String,System.Boolean)')
- [SlackAttachmentField](#T-SlackWebhook-Messages-SlackAttachmentField 'SlackWebhook.Messages.SlackAttachmentField')
  - [Short](#P-SlackWebhook-Messages-SlackAttachmentField-Short 'SlackWebhook.Messages.SlackAttachmentField.Short')
  - [Title](#P-SlackWebhook-Messages-SlackAttachmentField-Title 'SlackWebhook.Messages.SlackAttachmentField.Title')
  - [Value](#P-SlackWebhook-Messages-SlackAttachmentField-Value 'SlackWebhook.Messages.SlackAttachmentField.Value')
  - [Clone()](#M-SlackWebhook-Messages-SlackAttachmentField-Clone 'SlackWebhook.Messages.SlackAttachmentField.Clone')
  - [Validate()](#M-SlackWebhook-Messages-SlackAttachmentField-Validate-System-Collections-Generic-ICollection{SlackWebhook-Exceptions-ValidationError}@- 'SlackWebhook.Messages.SlackAttachmentField.Validate(System.Collections.Generic.ICollection{SlackWebhook.Exceptions.ValidationError}@)')
- [SlackAttachmentLinkButtonAction](#T-SlackWebhook-Messages-SlackAttachmentLinkButtonAction 'SlackWebhook.Messages.SlackAttachmentLinkButtonAction')
  - [#ctor()](#M-SlackWebhook-Messages-SlackAttachmentLinkButtonAction-#ctor 'SlackWebhook.Messages.SlackAttachmentLinkButtonAction.#ctor')
  - [Style](#P-SlackWebhook-Messages-SlackAttachmentLinkButtonAction-Style 'SlackWebhook.Messages.SlackAttachmentLinkButtonAction.Style')
  - [Url](#P-SlackWebhook-Messages-SlackAttachmentLinkButtonAction-Url 'SlackWebhook.Messages.SlackAttachmentLinkButtonAction.Url')
  - [Clone()](#M-SlackWebhook-Messages-SlackAttachmentLinkButtonAction-Clone 'SlackWebhook.Messages.SlackAttachmentLinkButtonAction.Clone')
  - [Validate()](#M-SlackWebhook-Messages-SlackAttachmentLinkButtonAction-Validate-System-Collections-Generic-ICollection{SlackWebhook-Exceptions-ValidationError}@- 'SlackWebhook.Messages.SlackAttachmentLinkButtonAction.Validate(System.Collections.Generic.ICollection{SlackWebhook.Exceptions.ValidationError}@)')
- [SlackClient](#T-SlackWebhook-SlackClient 'SlackWebhook.SlackClient')
  - [#ctor()](#M-SlackWebhook-SlackClient-#ctor-System-String- 'SlackWebhook.SlackClient.#ctor(System.String)')
  - [SendAsync()](#M-SlackWebhook-SlackClient-SendAsync-System-Action{SlackWebhook-ISlackMessageBuilder}- 'SlackWebhook.SlackClient.SendAsync(System.Action{SlackWebhook.ISlackMessageBuilder})')
  - [SendAsync()](#M-SlackWebhook-SlackClient-SendAsync-SlackWebhook-Messages-SlackMessage- 'SlackWebhook.SlackClient.SendAsync(SlackWebhook.Messages.SlackMessage)')
- [SlackMessage](#T-SlackWebhook-Messages-SlackMessage 'SlackWebhook.Messages.SlackMessage')
  - [Attachments](#P-SlackWebhook-Messages-SlackMessage-Attachments 'SlackWebhook.Messages.SlackMessage.Attachments')
  - [Channel](#P-SlackWebhook-Messages-SlackMessage-Channel 'SlackWebhook.Messages.SlackMessage.Channel')
  - [EnableFormatting](#P-SlackWebhook-Messages-SlackMessage-EnableFormatting 'SlackWebhook.Messages.SlackMessage.EnableFormatting')
  - [IconEmoji](#P-SlackWebhook-Messages-SlackMessage-IconEmoji 'SlackWebhook.Messages.SlackMessage.IconEmoji')
  - [IconUrl](#P-SlackWebhook-Messages-SlackMessage-IconUrl 'SlackWebhook.Messages.SlackMessage.IconUrl')
  - [Text](#P-SlackWebhook-Messages-SlackMessage-Text 'SlackWebhook.Messages.SlackMessage.Text')
  - [Username](#P-SlackWebhook-Messages-SlackMessage-Username 'SlackWebhook.Messages.SlackMessage.Username')
  - [Clone()](#M-SlackWebhook-Messages-SlackMessage-Clone 'SlackWebhook.Messages.SlackMessage.Clone')
  - [ThrowIfInvalid()](#M-SlackWebhook-Messages-SlackMessage-ThrowIfInvalid 'SlackWebhook.Messages.SlackMessage.ThrowIfInvalid')
  - [Validate()](#M-SlackWebhook-Messages-SlackMessage-Validate-System-Collections-Generic-ICollection{SlackWebhook-Exceptions-ValidationError}@- 'SlackWebhook.Messages.SlackMessage.Validate(System.Collections.Generic.ICollection{SlackWebhook.Exceptions.ValidationError}@)')
- [SlackMessageBuilder](#T-SlackWebhook-SlackMessageBuilder 'SlackWebhook.SlackMessageBuilder')
  - [#ctor()](#M-SlackWebhook-SlackMessageBuilder-#ctor 'SlackWebhook.SlackMessageBuilder.#ctor')
  - [Build()](#M-SlackWebhook-SlackMessageBuilder-Build 'SlackWebhook.SlackMessageBuilder.Build')
  - [WithAttachment()](#M-SlackWebhook-SlackMessageBuilder-WithAttachment-System-Action{SlackWebhook-ISlackAttachmentBuilder}- 'SlackWebhook.SlackMessageBuilder.WithAttachment(System.Action{SlackWebhook.ISlackAttachmentBuilder})')
  - [WithChannel()](#M-SlackWebhook-SlackMessageBuilder-WithChannel-System-String- 'SlackWebhook.SlackMessageBuilder.WithChannel(System.String)')
  - [WithIcon()](#M-SlackWebhook-SlackMessageBuilder-WithIcon-SlackWebhook-Enums-IconType,System-String- 'SlackWebhook.SlackMessageBuilder.WithIcon(SlackWebhook.Enums.IconType,System.String)')
  - [WithText()](#M-SlackWebhook-SlackMessageBuilder-WithText-System-String,System-Boolean- 'SlackWebhook.SlackMessageBuilder.WithText(System.String,System.Boolean)')
  - [WithUsername()](#M-SlackWebhook-SlackMessageBuilder-WithUsername-System-String- 'SlackWebhook.SlackMessageBuilder.WithUsername(System.String)')
- [SlackMessageValidationException](#T-SlackWebhook-Exceptions-SlackMessageValidationException 'SlackWebhook.Exceptions.SlackMessageValidationException')
  - [#ctor(message,validationErrors)](#M-SlackWebhook-Exceptions-SlackMessageValidationException-#ctor-System-String,System-Collections-Generic-IEnumerable{SlackWebhook-Exceptions-ValidationError}- 'SlackWebhook.Exceptions.SlackMessageValidationException.#ctor(System.String,System.Collections.Generic.IEnumerable{SlackWebhook.Exceptions.ValidationError})')
  - [ValidationErrors](#P-SlackWebhook-Exceptions-SlackMessageValidationException-ValidationErrors 'SlackWebhook.Exceptions.SlackMessageValidationException.ValidationErrors')
- [ValidationError](#T-SlackWebhook-Exceptions-ValidationError 'SlackWebhook.Exceptions.ValidationError')
  - [#ctor(typeName,propertyName,error)](#M-SlackWebhook-Exceptions-ValidationError-#ctor-System-String,System-String,System-String- 'SlackWebhook.Exceptions.ValidationError.#ctor(System.String,System.String,System.String)')
  - [Error](#P-SlackWebhook-Exceptions-ValidationError-Error 'SlackWebhook.Exceptions.ValidationError.Error')
  - [PropertyName](#P-SlackWebhook-Exceptions-ValidationError-PropertyName 'SlackWebhook.Exceptions.ValidationError.PropertyName')
  - [TypeName](#P-SlackWebhook-Exceptions-ValidationError-TypeName 'SlackWebhook.Exceptions.ValidationError.TypeName')
  - [ToString()](#M-SlackWebhook-Exceptions-ValidationError-ToString 'SlackWebhook.Exceptions.ValidationError.ToString')

<a name='T-SlackWebhook-Enums-ActionStyle'></a>
## ActionStyle `type`

##### Namespace

SlackWebhook.Enums

##### Summary

Action type

<a name='F-SlackWebhook-Enums-ActionStyle-Danger'></a>
### Danger `constants`

##### Summary

Turns the button red and indicates it some kind of destructive action

<a name='F-SlackWebhook-Enums-ActionStyle-Primary'></a>
### Primary `constants`

##### Summary

Turns the button green and indicates the best forward action to take

<a name='T-SlackWebhook-Core-ActionStyleJsonConverter'></a>
## ActionStyleJsonConverter `type`

##### Namespace

SlackWebhook.Core

##### Summary

[ActionStyle](#T-SlackWebhook-Enums-ActionStyle 'SlackWebhook.Enums.ActionStyle')json converter

<a name='M-SlackWebhook-Core-ActionStyleJsonConverter-ReadJson-Newtonsoft-Json-JsonReader,System-Type,System-Nullable{SlackWebhook-Enums-ActionStyle},System-Boolean,Newtonsoft-Json-JsonSerializer-'></a>
### ReadJson() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-SlackWebhook-Core-ActionStyleJsonConverter-WriteJson-Newtonsoft-Json-JsonWriter,System-Nullable{SlackWebhook-Enums-ActionStyle},Newtonsoft-Json-JsonSerializer-'></a>
### WriteJson() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-SlackWebhook-Core-FormattedTextEncoder'></a>
## FormattedTextEncoder `type`

##### Namespace

SlackWebhook.Core

##### Summary

Handles escaping characters which the Slack webhook expects to be HTML 
encoded.



See https://api.slack.com/docs/message-formatting#how_to_escape_characters
for more.

<a name='T-SlackWebhook-Core-ICloneable`1'></a>
## ICloneable\`1 `type`

##### Namespace

SlackWebhook.Core

##### Summary

Cloneable type

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of clone |

<a name='M-SlackWebhook-Core-ICloneable`1-Clone'></a>
### Clone() `method`

##### Summary

Creates new clone of this instance

##### Returns

Cloned instance

##### Parameters

This method has no parameters.

<a name='T-SlackWebhook-Enums-IconType'></a>
## IconType `type`

##### Namespace

SlackWebhook.Enums

##### Summary

Icon type

<a name='F-SlackWebhook-Enums-IconType-Emoji'></a>
### Emoji `constants`

##### Summary

Icon is a slack emoji name, e.g.

```
smile 
```

<a name='F-SlackWebhook-Enums-IconType-Url'></a>
### Url `constants`

##### Summary

Icon is a image URL

<a name='T-SlackWebhook-ISlackAttachmentBuilder'></a>
## ISlackAttachmentBuilder `type`

##### Namespace

SlackWebhook

##### Summary

Slack attachment builder used to configure an attachment to be added to a [SlackMessage](#T-SlackWebhook-Messages-SlackMessage 'SlackWebhook.Messages.SlackMessage')

<a name='M-SlackWebhook-ISlackAttachmentBuilder-WithAuthor-System-String,System-String,System-String-'></a>
### WithAuthor(name,linkUrl,iconUrl) `method`

##### Summary

With author name, and optional link url and icon url

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Author name (required) |
| linkUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Author link url (optional) |
| iconUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Author icon url (optional) |

##### Remarks

The author parameters will display a small section at the top of a
message attachment.



A valid URL that will hyperlink the [AuthorName](#P-SlackWebhook-Messages-SlackAttachment-AuthorName 'SlackWebhook.Messages.SlackAttachment.AuthorName')text
mentioned above. Will only work if [AuthorName](#P-SlackWebhook-Messages-SlackAttachment-AuthorName 'SlackWebhook.Messages.SlackAttachment.AuthorName')is
present.



A valid URL that displays a small 16x16px image to the left of the
[AuthorName](#P-SlackWebhook-Messages-SlackAttachment-AuthorName 'SlackWebhook.Messages.SlackAttachment.AuthorName')text. Will only work if
[AuthorName](#P-SlackWebhook-Messages-SlackAttachment-AuthorName 'SlackWebhook.Messages.SlackAttachment.AuthorName')is present.

<a name='M-SlackWebhook-ISlackAttachmentBuilder-WithColor-System-String-'></a>
### WithColor(hexColor) `method`

##### Summary

With hex-based color

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| hexColor | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Hex color or one of named colors (good, warning, danger) |

##### Remarks

Like traffic signals, color-coding messages can quickly communicate
intent and help separate them from the flow of other messages in the
timeline.



An optional value that can either be one of good, warning, danger,
or any hex color code(eg. #439FE0). This value is used to color the
border along the left side of the message attachment.

<a name='M-SlackWebhook-ISlackAttachmentBuilder-WithColor-System-Drawing-Color-'></a>
### WithColor(color) `method`

##### Summary

With color from [Color](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Color 'System.Drawing.Color')instance

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| color | [System.Drawing.Color](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Color 'System.Drawing.Color') | Color instance to set color from |

<a name='M-SlackWebhook-ISlackAttachmentBuilder-WithFallback-System-String-'></a>
### WithFallback(fallback) `method`

##### Summary

With required plain-text summary of the attachment

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fallback | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

##### Remarks

A plain-text summary of the attachment. This text will be used in 
clients that don't show formatted text (eg. IRC, mobile 
notifications) and should not contain any markup.

<a name='M-SlackWebhook-ISlackAttachmentBuilder-WithField-System-String,System-String,System-Boolean,System-Boolean-'></a>
### WithField(title,value,isShort,enableFormatting) `method`

##### Summary

With attachment field shown as a table inside the message attachment

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| title | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Title of field



Shown as a bold heading above the value text. It cannot contain
markup and will be escaped for you. |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Value of field (may contain formatting if enabled)



The text value of the field. It may contain standard message markup
and must be escaped as normal. May be multi-line. |
| isShort | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether field can be shown side-by-side with other fields (optional) |
| enableFormatting | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether or not to enable formatting for value |

##### Remarks

If `enableFormatting`is enabled, you can use Slack message formatting in 
`value`and it will automatically be encoded according to slack encoding rules.

<a name='M-SlackWebhook-ISlackAttachmentBuilder-WithFooter-System-String,System-String-'></a>
### WithFooter(text,iconUrl) `method`

##### Summary

With footer text and optional footer icon

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| iconUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

##### Remarks

Add some brief text to help contextualize and identify an
attachment. Limited to 300 characters, and may be truncated further
when displayed to users in environments with limited screen real
estate.



To render a small icon beside your footer text, provide a publicly
accessible URL string in the footer_icon field. You must also
provide a footer for the field to be recognized.



We'll render what you provide at 16px by 16px. It's best to use an
image that is similarly sized.

<a name='M-SlackWebhook-ISlackAttachmentBuilder-WithImage-System-String-'></a>
### WithImage(url) `method`

##### Summary

With image url

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Image url |

##### Remarks

A valid URL to an image file that will be displayed inside a message
attachment. We currently support the following formats: GIF, JPEG,
PNG, and BMP.



Large images will be resized to a maximum width of 400px or a
maximum height of 500px, while still maintaining the original aspect
ratio.

<a name='M-SlackWebhook-ISlackAttachmentBuilder-WithLink-System-String-'></a>
### WithLink(url) `method`

##### Summary

With link on attachment title

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

##### Remarks

Link of title (optional)

<a name='M-SlackWebhook-ISlackAttachmentBuilder-WithLinkButtonAction-System-String,System-String,System-Nullable{SlackWebhook-Enums-ActionStyle}-'></a>
### WithLinkButtonAction(text,url,style) `method`

##### Summary

With link button action, shown at the bottom of the attachment

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Test shown on link button |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | URL opened if link button is pressed |
| style | [System.Nullable{SlackWebhook.Enums.ActionStyle}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{SlackWebhook.Enums.ActionStyle}') | Optional style |

##### Remarks

An attachment may contain multiple actions

<a name='M-SlackWebhook-ISlackAttachmentBuilder-WithPreText-System-String,System-Boolean-'></a>
### WithPreText(text,enableFormatting) `method`

##### Summary

With optional pre-text

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Pre-text |
| enableFormatting | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether or not to enable formatting for text |

##### Remarks

This is optional text that appears above the message attachment
block.

<a name='M-SlackWebhook-ISlackAttachmentBuilder-WithText-System-String,System-Boolean-'></a>
### WithText(text,enableFormatting) `method`

##### Summary

With optional text

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Text |
| enableFormatting | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether or not to enable formatting for text |

##### Remarks

This is the main text in a message attachment, and can contain
standard message markup. The content will automatically collapse if
it contains 700+ characters or 5+ linebreaks, and will display a
"Show more..." link to expand the content. Links posted in the text
field will not unfurl.



If `enableFormatting`is enabled, you can use Slack message formatting in 
`text`and it will automatically be encoded according to slack encoding rules.

<a name='M-SlackWebhook-ISlackAttachmentBuilder-WithThumbnail-System-String-'></a>
### WithThumbnail(url) `method`

##### Summary

With thumbnail url

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Thumbnail url |

##### Remarks

A valid URL to an image file that will be displayed as a thumbnail
on the right side of a message attachment. We currently support the
following formats: GIF, JPEG, PNG, and BMP.



The thumbnail's longest dimension will be scaled down to 75px while
maintaining the aspect ratio of the image. The filesize of the image
must also be less than 500 KB.



For best results, please use images that are already 75px by 75px.

<a name='M-SlackWebhook-ISlackAttachmentBuilder-WithTimestamp-System-DateTimeOffset-'></a>
### WithTimestamp(timestamp) `method`

##### Summary

With timestamp based on `timestamp`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| timestamp | [System.DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') | DateTimeOffset to set timestamp from |

##### Remarks

Does your attachment relate to something happening at a specific 
time?



By providing the ts field with an integer value in "epoch time",
the attachment will display an additional timestamp value as part of
the attachment's footer.



Use ts when referencing articles or happenings.Your message will 
have its own timestamp when published.



Example: Providing 123456789 would result in a rendered timestamp 
of Nov 29th, 1973.

<a name='M-SlackWebhook-ISlackAttachmentBuilder-WithTimestamp-System-Int32-'></a>
### WithTimestamp(epochTime) `method`

##### Summary

With epoc timestamp

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| epochTime | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Epoch timestamp |

##### Remarks

Does your attachment relate to something happening at a specific 
time?



By providing the ts field with an integer value in "epoch time",
the attachment will display an additional timestamp value as part of
the attachment's footer.



Use ts when referencing articles or happenings.Your message will 
have its own timestamp when published.



Example: Providing 123456789 would result in a rendered timestamp 
of Nov 29th, 1973.

<a name='M-SlackWebhook-ISlackAttachmentBuilder-WithTitle-System-String-'></a>
### WithTitle(title) `method`

##### Summary

With required title

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| title | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Title |

##### Remarks

The title is displayed as larger, bold text near the top of a
message attachment. By passing a valid URL in the
[TitleLink](#P-SlackWebhook-Messages-SlackAttachment-TitleLink 'SlackWebhook.Messages.SlackAttachment.TitleLink')parameter (optional), the title text will be

<a name='T-SlackWebhook-ISlackClient'></a>
## ISlackClient `type`

##### Namespace

SlackWebhook

##### Summary

Slack client

<a name='M-SlackWebhook-ISlackClient-SendAsync-System-Action{SlackWebhook-ISlackMessageBuilder}-'></a>
### SendAsync(configureBuilder) `method`

##### Summary

Send new [SlackMessage](#T-SlackWebhook-Messages-SlackMessage 'SlackWebhook.Messages.SlackMessage')by configuring the provided [ISlackMessageBuilder](#T-SlackWebhook-ISlackMessageBuilder 'SlackWebhook.ISlackMessageBuilder')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configureBuilder | [System.Action{SlackWebhook.ISlackMessageBuilder}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{SlackWebhook.ISlackMessageBuilder}') | Configure message to send using this builder |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [SlackWebhook.Exceptions.SlackMessageValidationException](#T-SlackWebhook-Exceptions-SlackMessageValidationException 'SlackWebhook.Exceptions.SlackMessageValidationException') | Thrown if validation of the message fails, such as if a required field is missing.



Uses [Validate](#M-SlackWebhook-Messages-SlackMessage-Validate-System-Collections-Generic-ICollection{SlackWebhook-Exceptions-ValidationError}@- 'SlackWebhook.Messages.SlackMessage.Validate(System.Collections.Generic.ICollection{SlackWebhook.Exceptions.ValidationError}@)')to perform validation. |

<a name='M-SlackWebhook-ISlackClient-SendAsync-SlackWebhook-Messages-SlackMessage-'></a>
### SendAsync(message) `method`

##### Summary

Send the provided [SlackMessage](#T-SlackWebhook-Messages-SlackMessage 'SlackWebhook.Messages.SlackMessage')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [SlackWebhook.Messages.SlackMessage](#T-SlackWebhook-Messages-SlackMessage 'SlackWebhook.Messages.SlackMessage') | Slack message to send |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [SlackWebhook.Exceptions.SlackMessageValidationException](#T-SlackWebhook-Exceptions-SlackMessageValidationException 'SlackWebhook.Exceptions.SlackMessageValidationException') | Thrown if validation of the message fails, such as if a required field is missing.



Uses [Validate](#M-SlackWebhook-Messages-SlackMessage-Validate-System-Collections-Generic-ICollection{SlackWebhook-Exceptions-ValidationError}@- 'SlackWebhook.Messages.SlackMessage.Validate(System.Collections.Generic.ICollection{SlackWebhook.Exceptions.ValidationError}@)')to perform validation. |

<a name='T-SlackWebhook-ISlackMessageBuilder'></a>
## ISlackMessageBuilder `type`

##### Namespace

SlackWebhook

##### Summary

Slack message builder that produces [SlackMessage](#T-SlackWebhook-Messages-SlackMessage 'SlackWebhook.Messages.SlackMessage')instances based on the builder's
current configuration.

<a name='M-SlackWebhook-ISlackMessageBuilder-Build'></a>
### Build() `method`

##### Summary

Build [SlackMessage](#T-SlackWebhook-Messages-SlackMessage 'SlackWebhook.Messages.SlackMessage')based on current state of the builder

##### Returns

New message

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [SlackWebhook.Exceptions.SlackMessageValidationException](#T-SlackWebhook-Exceptions-SlackMessageValidationException 'SlackWebhook.Exceptions.SlackMessageValidationException') | Thrown if validation of the message fails, such as if a required field is missing.



Uses [Validate](#M-SlackWebhook-Messages-SlackMessage-Validate-System-Collections-Generic-ICollection{SlackWebhook-Exceptions-ValidationError}@- 'SlackWebhook.Messages.SlackMessage.Validate(System.Collections.Generic.ICollection{SlackWebhook.Exceptions.ValidationError}@)')to perform validation. |

<a name='M-SlackWebhook-ISlackMessageBuilder-WithAttachment-System-Action{SlackWebhook-ISlackAttachmentBuilder}-'></a>
### WithAttachment(configureAttachment) `method`

##### Summary

With attachment build with provided attachment builder

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configureAttachment | [System.Action{SlackWebhook.ISlackAttachmentBuilder}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{SlackWebhook.ISlackAttachmentBuilder}') | Attachment builder |

##### Remarks

Adds a new [SlackAttachment](#T-SlackWebhook-Messages-SlackAttachment 'SlackWebhook.Messages.SlackAttachment')to [Attachments](#P-SlackWebhook-Messages-SlackMessage-Attachments 'SlackWebhook.Messages.SlackMessage.Attachments')built using provided 
[ISlackAttachmentBuilder](#T-SlackWebhook-ISlackAttachmentBuilder 'SlackWebhook.ISlackAttachmentBuilder')

<a name='M-SlackWebhook-ISlackMessageBuilder-WithChannel-System-String-'></a>
### WithChannel(channel) `method`

##### Summary

With channel

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| channel | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The channel. |

##### Remarks

Sets the [Channel](#P-SlackWebhook-Messages-SlackMessage-Channel 'SlackWebhook.Messages.SlackMessage.Channel')property

<a name='M-SlackWebhook-ISlackMessageBuilder-WithIcon-SlackWebhook-Enums-IconType,System-String-'></a>
### WithIcon(iconType,urlOrEmoji) `method`

##### Summary

With icon (url or emoji)

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| iconType | [SlackWebhook.Enums.IconType](#T-SlackWebhook-Enums-IconType 'SlackWebhook.Enums.IconType') | Type of icon |
| urlOrEmoji | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | URL or emoji name (depending on `iconType`) |

##### Remarks

Sets the [IconUrl](#P-SlackWebhook-Messages-SlackMessage-IconUrl 'SlackWebhook.Messages.SlackMessage.IconUrl')or [IconEmoji](#P-SlackWebhook-Messages-SlackMessage-IconEmoji 'SlackWebhook.Messages.SlackMessage.IconEmoji')based on
`iconType`with the provided value `urlOrEmoji`

<a name='M-SlackWebhook-ISlackMessageBuilder-WithText-System-String,System-Boolean-'></a>
### WithText(text,enableFormatting) `method`

##### Summary

With required message text

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Message text |
| enableFormatting | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether or not to enable formatting for text |

##### Remarks

Sets the [Text](#P-SlackWebhook-Messages-SlackMessage-Text 'SlackWebhook.Messages.SlackMessage.Text')and [EnableFormatting](#P-SlackWebhook-Messages-SlackMessage-EnableFormatting 'SlackWebhook.Messages.SlackMessage.EnableFormatting')properties.



If `enableFormatting`is enabled, you can use Slack message formatting in
`text`and it will automatically be encoded according to slack encoding rules.

<a name='M-SlackWebhook-ISlackMessageBuilder-WithUsername-System-String-'></a>
### WithUsername(username) `method`

##### Summary

With username

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| username | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Username |

##### Remarks

Sets the [Username](#P-SlackWebhook-Messages-SlackMessage-Username 'SlackWebhook.Messages.SlackMessage.Username')property

<a name='T-SlackWebhook-Core-IValidateable'></a>
## IValidateable `type`

##### Namespace

SlackWebhook.Core

##### Summary

Object can be validated

<a name='M-SlackWebhook-Core-IValidateable-Validate-System-Collections-Generic-ICollection{SlackWebhook-Exceptions-ValidationError}@-'></a>
### Validate(validationErrors) `method`

##### Summary

Validates the current state of the object (including any nested validateable members)

##### Returns

True if the object is valid, false otherwise

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| validationErrors | [System.Collections.Generic.ICollection{SlackWebhook.Exceptions.ValidationError}@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ICollection 'System.Collections.Generic.ICollection{SlackWebhook.Exceptions.ValidationError}@') | Validation errors (if any found) |

##### Remarks

Will find all (if any) validation errors and populate `validationErrors`with each

<a name='T-SlackWebhook-Messages-SlackAttachment'></a>
## SlackAttachment `type`

##### Namespace

SlackWebhook.Messages

##### Summary

Optional attachment to a [SlackMessage](#T-SlackWebhook-Messages-SlackMessage 'SlackWebhook.Messages.SlackMessage').



See https://api.slack.com/docs/message-attachments for more details

<a name='F-SlackWebhook-Messages-SlackAttachment-FormattingFields'></a>
### FormattingFields `constants`

##### Summary

Used to enable formatting of the [Fields](#P-SlackWebhook-Messages-SlackAttachment-Fields 'SlackWebhook.Messages.SlackAttachment.Fields')value fields

<a name='F-SlackWebhook-Messages-SlackAttachment-FormattingPretext'></a>
### FormattingPretext `constants`

##### Summary

Used to enable formatting of the [PreText](#P-SlackWebhook-Messages-SlackAttachment-PreText 'SlackWebhook.Messages.SlackAttachment.PreText')field

<a name='F-SlackWebhook-Messages-SlackAttachment-FormattingText'></a>
### FormattingText `constants`

##### Summary

Used to enable formatting of the [Text](#P-SlackWebhook-Messages-SlackAttachment-Text 'SlackWebhook.Messages.SlackAttachment.Text')field

<a name='P-SlackWebhook-Messages-SlackAttachment-Actions'></a>
### Actions `property`

##### Summary

Actions shown at the bottom of the message (optional)

<a name='P-SlackWebhook-Messages-SlackAttachment-AuthorIcon'></a>
### AuthorIcon `property`

##### Summary

Author icon URL (optional)

##### Remarks

A valid URL that displays a small 16x16px image to the left of the
[AuthorName](#P-SlackWebhook-Messages-SlackAttachment-AuthorName 'SlackWebhook.Messages.SlackAttachment.AuthorName')text. Will only work if
[AuthorName](#P-SlackWebhook-Messages-SlackAttachment-AuthorName 'SlackWebhook.Messages.SlackAttachment.AuthorName')is present.

<a name='P-SlackWebhook-Messages-SlackAttachment-AuthorLink'></a>
### AuthorLink `property`

##### Summary

Author link (optional)

##### Remarks

A valid URL that will hyperlink the [AuthorName](#P-SlackWebhook-Messages-SlackAttachment-AuthorName 'SlackWebhook.Messages.SlackAttachment.AuthorName')text
mentioned above. Will only work if [AuthorName](#P-SlackWebhook-Messages-SlackAttachment-AuthorName 'SlackWebhook.Messages.SlackAttachment.AuthorName')is
present.

<a name='P-SlackWebhook-Messages-SlackAttachment-AuthorName'></a>
### AuthorName `property`

##### Summary

Author name (optional)

##### Remarks

The author parameters will display a small section at the top of a
message attachment

<a name='P-SlackWebhook-Messages-SlackAttachment-Color'></a>
### Color `property`

##### Summary

Gets or sets the color.

##### Remarks

Like traffic signals, color-coding messages can quickly communicate
intent and help separate them from the flow of other messages in the
timeline.



An optional value that can either be one of good, warning, danger,
or any hex color code(eg. #439FE0). This value is used to color the
border along the left side of the message attachment.

<a name='P-SlackWebhook-Messages-SlackAttachment-EnableFormatting'></a>
### EnableFormatting `property`

##### Summary

Enable formatting for various fields of the attachment, use 
[FormattingText](#F-SlackWebhook-Messages-SlackAttachment-FormattingText 'SlackWebhook.Messages.SlackAttachment.FormattingText'), [FormattingPretext](#F-SlackWebhook-Messages-SlackAttachment-FormattingPretext 'SlackWebhook.Messages.SlackAttachment.FormattingPretext')and
[FormattingFields](#F-SlackWebhook-Messages-SlackAttachment-FormattingFields 'SlackWebhook.Messages.SlackAttachment.FormattingFields')to contorl which fields have 
formatting enabled.

<a name='P-SlackWebhook-Messages-SlackAttachment-Fallback'></a>
### Fallback `property`

##### Summary

Required plain-text summary of the attachment

##### Remarks

A plain-text summary of the attachment. This text will be used in 
clients that don't show formatted text (eg. IRC, mobile 
notifications) and should not contain any markup.

<a name='P-SlackWebhook-Messages-SlackAttachment-Fields'></a>
### Fields `property`

##### Summary

Fields shown as a table inside the message attachment (optional)

<a name='P-SlackWebhook-Messages-SlackAttachment-Footer'></a>
### Footer `property`

##### Summary

Footer text shown at the bottom of attachment (optional)

##### Remarks

Add some brief text to help contextualize and identify an
attachment. Limited to 300 characters, and may be truncated further
when displayed to users in environments with limited screen real
estate.

<a name='P-SlackWebhook-Messages-SlackAttachment-FooterIcon'></a>
### FooterIcon `property`

##### Summary

Icon shown left of footer text (optional)

##### Remarks

To render a small icon beside your footer text, provide a publicly
accessible URL string in the footer_icon field. You must also
provide a footer for the field to be recognized.



We'll render what you provide at 16px by 16px. It's best to use an
image that is similarly sized.

<a name='P-SlackWebhook-Messages-SlackAttachment-ImageUrl'></a>
### ImageUrl `property`

##### Summary

Image url (optional)

##### Remarks

A valid URL to an image file that will be displayed inside a message
attachment. We currently support the following formats: GIF, JPEG,
PNG, and BMP.



Large images will be resized to a maximum width of 400px or a
maximum height of 500px, while still maintaining the original aspect
ratio.

<a name='P-SlackWebhook-Messages-SlackAttachment-PreText'></a>
### PreText `property`

##### Summary

Optional text that appears above the attachment block

##### Remarks

This is optional text that appears above the message attachment
block.

<a name='P-SlackWebhook-Messages-SlackAttachment-Text'></a>
### Text `property`

##### Summary

Optional text that appears within the attachment

##### Remarks

This is the main text in a message attachment, and can contain
standard message markup. The content will automatically collapse if
it contains 700+ characters or 5+ linebreaks, and will display a
"Show more..." link to expand the content. Links posted in the text
field will not unfurl.

<a name='P-SlackWebhook-Messages-SlackAttachment-ThumbnailUrl'></a>
### ThumbnailUrl `property`

##### Summary

Thumbnail url (optional)

##### Remarks

A valid URL to an image file that will be displayed as a thumbnail
on the right side of a message attachment. We currently support the
following formats: GIF, JPEG, PNG, and BMP.



The thumbnail's longest dimension will be scaled down to 75px while
maintaining the aspect ratio of the image. The filesize of the image
must also be less than 500 KB.



For best results, please use images that are already 75px by 75px.

<a name='P-SlackWebhook-Messages-SlackAttachment-Timestamp'></a>
### Timestamp `property`

##### Summary

Timestamp (epoch time) shown below attachment (optional)

##### Remarks

Does your attachment relate to something happening at a specific 
time?



By providing the ts field with an integer value in "epoch time",
the attachment will display an additional timestamp value as part of
the attachment's footer.



Use ts when referencing articles or happenings.Your message will 
have its own timestamp when published.



Example: Providing 123456789 would result in a rendered timestamp 
of Nov 29th, 1973.

<a name='P-SlackWebhook-Messages-SlackAttachment-Title'></a>
### Title `property`

##### Summary

Title of attachment (required)

##### Remarks

The title is displayed as larger, bold text near the top of a
message attachment. By passing a valid URL in the
[TitleLink](#P-SlackWebhook-Messages-SlackAttachment-TitleLink 'SlackWebhook.Messages.SlackAttachment.TitleLink')parameter (optional), the title text will be
hyperlinked.

<a name='P-SlackWebhook-Messages-SlackAttachment-TitleLink'></a>
### TitleLink `property`

##### Summary

Link of title (optional)

<a name='M-SlackWebhook-Messages-SlackAttachment-Clone'></a>
### Clone() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-SlackWebhook-Messages-SlackAttachment-SetColor-System-Drawing-Color-'></a>
### SetColor(color) `method`

##### Summary

Set color hex code from [Color](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Color 'System.Drawing.Color')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| color | [System.Drawing.Color](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Drawing.Color 'System.Drawing.Color') | Color to set color hex from |

<a name='M-SlackWebhook-Messages-SlackAttachment-SetTimestamp-System-DateTimeOffset-'></a>
### SetTimestamp(timestamp) `method`

##### Summary

Set [Timestamp](#P-SlackWebhook-Messages-SlackAttachment-Timestamp 'SlackWebhook.Messages.SlackAttachment.Timestamp')epoch value based on provided date time

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| timestamp | [System.DateTimeOffset](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTimeOffset 'System.DateTimeOffset') | Timestamp to set epohc time from |

<a name='M-SlackWebhook-Messages-SlackAttachment-Validate-System-Collections-Generic-ICollection{SlackWebhook-Exceptions-ValidationError}@-'></a>
### Validate() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-SlackWebhook-Messages-SlackAttachmentAction'></a>
## SlackAttachmentAction `type`

##### Namespace

SlackWebhook.Messages

##### Summary

Optional action to se [SlackAttachment](#T-SlackWebhook-Messages-SlackAttachment 'SlackWebhook.Messages.SlackAttachment').

<a name='M-SlackWebhook-Messages-SlackAttachmentAction-#ctor-System-String-'></a>
### #ctor(type) `constructor`

##### Summary

Initialize attachment action

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Type of action |

<a name='P-SlackWebhook-Messages-SlackAttachmentAction-Text'></a>
### Text `property`

##### Summary

Text displayed for the action

##### Remarks

How this is presented depends on the type of action

<a name='P-SlackWebhook-Messages-SlackAttachmentAction-Type'></a>
### Type `property`

##### Summary

Type of action

<a name='M-SlackWebhook-Messages-SlackAttachmentAction-Clone'></a>
### Clone() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-SlackWebhook-Messages-SlackAttachmentAction-Validate-System-Collections-Generic-ICollection{SlackWebhook-Exceptions-ValidationError}@-'></a>
### Validate() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-SlackWebhook-SlackAttachmentBuilder'></a>
## SlackAttachmentBuilder `type`

##### Namespace

SlackWebhook

<a name='M-SlackWebhook-SlackAttachmentBuilder-SetEnableFormatting-System-String,System-Boolean-'></a>
### SetEnableFormatting(formattingType,enable) `method`

##### Summary

Enables or disables formatting by adding/removing `formattingType`from
[EnableFormatting](#P-SlackWebhook-Messages-SlackAttachment-EnableFormatting 'SlackWebhook.Messages.SlackAttachment.EnableFormatting')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| formattingType | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Formatting type |
| enable | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Whether to enable (add) or disable (remove) |

<a name='T-SlackWebhook-Messages-SlackAttachmentField'></a>
## SlackAttachmentField `type`

##### Namespace

SlackWebhook.Messages

##### Summary

Optional attachment field added to [Fields](#P-SlackWebhook-Messages-SlackAttachment-Fields 'SlackWebhook.Messages.SlackAttachment.Fields')

<a name='P-SlackWebhook-Messages-SlackAttachmentField-Short'></a>
### Short `property`

##### Summary

Whether field can be shown side-by-side with other fields (optional)

<a name='P-SlackWebhook-Messages-SlackAttachmentField-Title'></a>
### Title `property`

##### Summary

Title of field

##### Remarks

Shown as a bold heading above the value text. It cannot contain
markup and will be escaped for you.

<a name='P-SlackWebhook-Messages-SlackAttachmentField-Value'></a>
### Value `property`

##### Summary

Value of field (may contain formatting if enabled)

##### Remarks

The text value of the field. It may contain standard message markup
and must be escaped as normal. May be multi-line.

<a name='M-SlackWebhook-Messages-SlackAttachmentField-Clone'></a>
### Clone() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-SlackWebhook-Messages-SlackAttachmentField-Validate-System-Collections-Generic-ICollection{SlackWebhook-Exceptions-ValidationError}@-'></a>
### Validate() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-SlackWebhook-Messages-SlackAttachmentLinkButtonAction'></a>
## SlackAttachmentLinkButtonAction `type`

##### Namespace

SlackWebhook.Messages

##### Summary

Button action which will open a [Url](#P-SlackWebhook-Messages-SlackAttachmentLinkButtonAction-Url 'SlackWebhook.Messages.SlackAttachmentLinkButtonAction.Url'), if clicked

<a name='M-SlackWebhook-Messages-SlackAttachmentLinkButtonAction-#ctor'></a>
### #ctor() `constructor`

##### Summary

Create new empty link button action

##### Parameters

This constructor has no parameters.

<a name='P-SlackWebhook-Messages-SlackAttachmentLinkButtonAction-Style'></a>
### Style `property`

##### Summary

Optional style

<a name='P-SlackWebhook-Messages-SlackAttachmentLinkButtonAction-Url'></a>
### Url `property`

##### Summary

URL to open if link button is clicked

<a name='M-SlackWebhook-Messages-SlackAttachmentLinkButtonAction-Clone'></a>
### Clone() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-SlackWebhook-Messages-SlackAttachmentLinkButtonAction-Validate-System-Collections-Generic-ICollection{SlackWebhook-Exceptions-ValidationError}@-'></a>
### Validate() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-SlackWebhook-SlackClient'></a>
## SlackClient `type`

##### Namespace

SlackWebhook

##### Summary

*Inherit from parent.*

<a name='M-SlackWebhook-SlackClient-#ctor-System-String-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-SlackWebhook-SlackClient-SendAsync-System-Action{SlackWebhook-ISlackMessageBuilder}-'></a>
### SendAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-SlackWebhook-SlackClient-SendAsync-SlackWebhook-Messages-SlackMessage-'></a>
### SendAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-SlackWebhook-Messages-SlackMessage'></a>
## SlackMessage `type`

##### Namespace

SlackWebhook.Messages

##### Summary

Basis for a Slack message which can be sent to the webhook URL

<a name='P-SlackWebhook-Messages-SlackMessage-Attachments'></a>
### Attachments `property`

##### Summary

Attachments to show below message (optional)

<a name='P-SlackWebhook-Messages-SlackMessage-Channel'></a>
### Channel `property`

##### Summary

Channel the message is posted into (optional)

<a name='P-SlackWebhook-Messages-SlackMessage-EnableFormatting'></a>
### EnableFormatting `property`

##### Summary

Whether or not to enable formatting for this message

##### Remarks

Default true

<a name='P-SlackWebhook-Messages-SlackMessage-IconEmoji'></a>
### IconEmoji `property`

##### Summary

Icon emoji name () (optional)

##### Remarks

Either provide this OR [IconUrl](#P-SlackWebhook-Messages-SlackMessage-IconUrl 'SlackWebhook.Messages.SlackMessage.IconUrl'), but not both

<a name='P-SlackWebhook-Messages-SlackMessage-IconUrl'></a>
### IconUrl `property`

##### Summary

Icon URL to show before username (optional)

##### Remarks

Either provide this OR [IconEmoji](#P-SlackWebhook-Messages-SlackMessage-IconEmoji 'SlackWebhook.Messages.SlackMessage.IconEmoji'), but not both

<a name='P-SlackWebhook-Messages-SlackMessage-Text'></a>
### Text `property`

##### Summary

Message text which may contain formatting (unless 
[EnableFormatting](#P-SlackWebhook-Messages-SlackMessage-EnableFormatting 'SlackWebhook.Messages.SlackMessage.EnableFormatting')is deactivated) and can span 
multiple lines.

##### Remarks

You can use the regular Slack formatting

```
    *bold* `code` _italic_ ~strike~ 
```

and also include links

```
    &lt;URL|title&gt; 
```

<a name='P-SlackWebhook-Messages-SlackMessage-Username'></a>
### Username `property`

##### Summary

Username shown (optional)

<a name='M-SlackWebhook-Messages-SlackMessage-Clone'></a>
### Clone() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-SlackWebhook-Messages-SlackMessage-ThrowIfInvalid'></a>
### ThrowIfInvalid() `method`

##### Summary

Checks the current state using [Validate](#M-SlackWebhook-Messages-SlackMessage-Validate-System-Collections-Generic-ICollection{SlackWebhook-Exceptions-ValidationError}@- 'SlackWebhook.Messages.SlackMessage.Validate(System.Collections.Generic.ICollection{SlackWebhook.Exceptions.ValidationError}@)')and throws a 
[SlackMessageValidationException](#T-SlackWebhook-Exceptions-SlackMessageValidationException 'SlackWebhook.Exceptions.SlackMessageValidationException')with all validations errors, if any 
are found.

##### Parameters

This method has no parameters.

<a name='M-SlackWebhook-Messages-SlackMessage-Validate-System-Collections-Generic-ICollection{SlackWebhook-Exceptions-ValidationError}@-'></a>
### Validate() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-SlackWebhook-SlackMessageBuilder'></a>
## SlackMessageBuilder `type`

##### Namespace

SlackWebhook

##### Summary

*Inherit from parent.*

<a name='M-SlackWebhook-SlackMessageBuilder-#ctor'></a>
### #ctor() `constructor`

##### Summary

Create new slack message builder

##### Parameters

This constructor has no parameters.

<a name='M-SlackWebhook-SlackMessageBuilder-Build'></a>
### Build() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-SlackWebhook-SlackMessageBuilder-WithAttachment-System-Action{SlackWebhook-ISlackAttachmentBuilder}-'></a>
### WithAttachment() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-SlackWebhook-SlackMessageBuilder-WithChannel-System-String-'></a>
### WithChannel() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-SlackWebhook-SlackMessageBuilder-WithIcon-SlackWebhook-Enums-IconType,System-String-'></a>
### WithIcon() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-SlackWebhook-SlackMessageBuilder-WithText-System-String,System-Boolean-'></a>
### WithText() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-SlackWebhook-SlackMessageBuilder-WithUsername-System-String-'></a>
### WithUsername() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-SlackWebhook-Exceptions-SlackMessageValidationException'></a>
## SlackMessageValidationException `type`

##### Namespace

SlackWebhook.Exceptions

##### Summary

Slack message validation exception

<a name='M-SlackWebhook-Exceptions-SlackMessageValidationException-#ctor-System-String,System-Collections-Generic-IEnumerable{SlackWebhook-Exceptions-ValidationError}-'></a>
### #ctor(message,validationErrors) `constructor`

##### Summary

Create new validation exception

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Exception message |
| validationErrors | [System.Collections.Generic.IEnumerable{SlackWebhook.Exceptions.ValidationError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{SlackWebhook.Exceptions.ValidationError}') | Validation errors |

<a name='P-SlackWebhook-Exceptions-SlackMessageValidationException-ValidationErrors'></a>
### ValidationErrors `property`

##### Summary

Validations errors

<a name='T-SlackWebhook-Exceptions-ValidationError'></a>
## ValidationError `type`

##### Namespace

SlackWebhook.Exceptions

##### Summary

Validation error details

<a name='M-SlackWebhook-Exceptions-ValidationError-#ctor-System-String,System-String,System-String-'></a>
### #ctor(typeName,propertyName,error) `constructor`

##### Summary

Create new validation error

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| typeName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Type where validation error occurred |
| propertyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Property which failed validation |
| error | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Validation error |

<a name='P-SlackWebhook-Exceptions-ValidationError-Error'></a>
### Error `property`

##### Summary

Validation error

<a name='P-SlackWebhook-Exceptions-ValidationError-PropertyName'></a>
### PropertyName `property`

##### Summary

Property which failed validation

<a name='P-SlackWebhook-Exceptions-ValidationError-TypeName'></a>
### TypeName `property`

##### Summary

Type where validation error occurred

<a name='M-SlackWebhook-Exceptions-ValidationError-ToString'></a>
### ToString() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.
