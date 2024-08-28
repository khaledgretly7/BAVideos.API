<a name='assembly'></a>
# Bibliothetica Alexandrina Video API

## Contents

- [CategoriesController](#T-BibALEXapi-Controllers-CategoriesController 'BibALEXapi.Controllers.CategoriesController')
  - [DeleteCategory(id)](#M-BibALEXapi-Controllers-CategoriesController-DeleteCategory-System-Int32- 'BibALEXapi.Controllers.CategoriesController.DeleteCategory(System.Int32)')
  - [GetCategories()](#M-BibALEXapi-Controllers-CategoriesController-GetCategories 'BibALEXapi.Controllers.CategoriesController.GetCategories')
  - [GetCategory(id)](#M-BibALEXapi-Controllers-CategoriesController-GetCategory-System-Int32- 'BibALEXapi.Controllers.CategoriesController.GetCategory(System.Int32)')
  - [PostCategory(category)](#M-BibALEXapi-Controllers-CategoriesController-PostCategory-BibALEXapi-Models-Category- 'BibALEXapi.Controllers.CategoriesController.PostCategory(BibALEXapi.Models.Category)')
  - [PutCategory(id,category)](#M-BibALEXapi-Controllers-CategoriesController-PutCategory-System-Int32,BibALEXapi-Models-Category- 'BibALEXapi.Controllers.CategoriesController.PutCategory(System.Int32,BibALEXapi.Models.Category)')
- [ChannelsController](#T-BibALEXapi-Controllers-ChannelsController 'BibALEXapi.Controllers.ChannelsController')
  - [DeleteChannel(id)](#M-BibALEXapi-Controllers-ChannelsController-DeleteChannel-System-Int32- 'BibALEXapi.Controllers.ChannelsController.DeleteChannel(System.Int32)')
  - [GetChannel(id)](#M-BibALEXapi-Controllers-ChannelsController-GetChannel-System-Int32- 'BibALEXapi.Controllers.ChannelsController.GetChannel(System.Int32)')
  - [GetChannels()](#M-BibALEXapi-Controllers-ChannelsController-GetChannels 'BibALEXapi.Controllers.ChannelsController.GetChannels')
  - [PostChannel(channel)](#M-BibALEXapi-Controllers-ChannelsController-PostChannel-BibALEXapi-Models-ChannelDTO- 'BibALEXapi.Controllers.ChannelsController.PostChannel(BibALEXapi.Models.ChannelDTO)')
  - [PutChannel(id,channel)](#M-BibALEXapi-Controllers-ChannelsController-PutChannel-System-Int32,BibALEXapi-Models-ChannelDTO- 'BibALEXapi.Controllers.ChannelsController.PutChannel(System.Int32,BibALEXapi.Models.ChannelDTO)')
- [PlaylistsController](#T-BibALEXapi-Controllers-PlaylistsController 'BibALEXapi.Controllers.PlaylistsController')
  - [DeletePlaylist(id)](#M-BibALEXapi-Controllers-PlaylistsController-DeletePlaylist-System-Int32- 'BibALEXapi.Controllers.PlaylistsController.DeletePlaylist(System.Int32)')
  - [GetPlaylist(id)](#M-BibALEXapi-Controllers-PlaylistsController-GetPlaylist-System-Int32- 'BibALEXapi.Controllers.PlaylistsController.GetPlaylist(System.Int32)')
  - [GetPlaylists(chid)](#M-BibALEXapi-Controllers-PlaylistsController-GetPlaylists-System-Int32- 'BibALEXapi.Controllers.PlaylistsController.GetPlaylists(System.Int32)')
  - [PostPlaylist(playlist)](#M-BibALEXapi-Controllers-PlaylistsController-PostPlaylist-BibALEXapi-Models-PlaylistDTO- 'BibALEXapi.Controllers.PlaylistsController.PostPlaylist(BibALEXapi.Models.PlaylistDTO)')
  - [PutPlaylist(id,playlist)](#M-BibALEXapi-Controllers-PlaylistsController-PutPlaylist-System-Int32,BibALEXapi-Models-PlaylistDTO- 'BibALEXapi.Controllers.PlaylistsController.PutPlaylist(System.Int32,BibALEXapi.Models.PlaylistDTO)')
- [VideosController](#T-BibALEXapi-Controllers-VideosController 'BibALEXapi.Controllers.VideosController')
  - [DeleteVideo(id)](#M-BibALEXapi-Controllers-VideosController-DeleteVideo-System-Int32- 'BibALEXapi.Controllers.VideosController.DeleteVideo(System.Int32)')
  - [GetVideo(id)](#M-BibALEXapi-Controllers-VideosController-GetVideo-System-Int32- 'BibALEXapi.Controllers.VideosController.GetVideo(System.Int32)')
  - [GetVideos(cid,pid,chid)](#M-BibALEXapi-Controllers-VideosController-GetVideos-System-Int32,System-Int32,System-Int32- 'BibALEXapi.Controllers.VideosController.GetVideos(System.Int32,System.Int32,System.Int32)')
  - [PostVideo(video)](#M-BibALEXapi-Controllers-VideosController-PostVideo-BibALEXapi-Models-VideoDTO- 'BibALEXapi.Controllers.VideosController.PostVideo(BibALEXapi.Models.VideoDTO)')
  - [PutVideo(id,video)](#M-BibALEXapi-Controllers-VideosController-PutVideo-System-Int32,BibALEXapi-Models-VideoDTO- 'BibALEXapi.Controllers.VideosController.PutVideo(System.Int32,BibALEXapi.Models.VideoDTO)')
- [VisibilitiesController](#T-BibALEXapi-Controllers-VisibilitiesController 'BibALEXapi.Controllers.VisibilitiesController')
  - [DeleteVisibility(id)](#M-BibALEXapi-Controllers-VisibilitiesController-DeleteVisibility-System-Int32- 'BibALEXapi.Controllers.VisibilitiesController.DeleteVisibility(System.Int32)')
  - [GetVisibilities()](#M-BibALEXapi-Controllers-VisibilitiesController-GetVisibilities 'BibALEXapi.Controllers.VisibilitiesController.GetVisibilities')
  - [GetVisibility(id)](#M-BibALEXapi-Controllers-VisibilitiesController-GetVisibility-System-Int32- 'BibALEXapi.Controllers.VisibilitiesController.GetVisibility(System.Int32)')
  - [PostVisibility(visibility)](#M-BibALEXapi-Controllers-VisibilitiesController-PostVisibility-BibALEXapi-Models-Visibility- 'BibALEXapi.Controllers.VisibilitiesController.PostVisibility(BibALEXapi.Models.Visibility)')
  - [PutVisibility(id,visibility)](#M-BibALEXapi-Controllers-VisibilitiesController-PutVisibility-System-Int32,BibALEXapi-Models-Visibility- 'BibALEXapi.Controllers.VisibilitiesController.PutVisibility(System.Int32,BibALEXapi.Models.Visibility)')

<a name='T-BibALEXapi-Controllers-CategoriesController'></a>
## CategoriesController `type`

##### Namespace

BibALEXapi.Controllers

##### Summary

The controller associated with the Channels.

<a name='M-BibALEXapi-Controllers-CategoriesController-DeleteCategory-System-Int32-'></a>
### DeleteCategory(id) `method`

##### Summary

Deletes an existing category

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The unique identifier for the category to be deleted |

<a name='M-BibALEXapi-Controllers-CategoriesController-GetCategories'></a>
### GetCategories() `method`

##### Summary

Retrieves all categories from the database.

##### Returns

A list of categories

##### Parameters

This method has no parameters.

<a name='M-BibALEXapi-Controllers-CategoriesController-GetCategory-System-Int32-'></a>
### GetCategory(id) `method`

##### Summary

Retrieves a specific category by its ID

##### Returns

The category associated with the ID

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The unique identifier for the desired category |

<a name='M-BibALEXapi-Controllers-CategoriesController-PostCategory-BibALEXapi-Models-Category-'></a>
### PostCategory(category) `method`

##### Summary

Inserts a new category into the database

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| category | [BibALEXapi.Models.Category](Models/Category.cs 'BibALEXapi.Models.Category') | The category to be inserted |

<a name='M-BibALEXapi-Controllers-CategoriesController-PutCategory-System-Int32,BibALEXapi-Models-Category-'></a>
### PutCategory(id,category) `method`

##### Summary

Updates the given category with a newer one. Requires authentication. The API gets authenticated from an external authentication provider.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The unique identifier of the category to be updated |
| category | [BibALEXapi.Models.Category](Models/Category.cs 'BibALEXapi.Models.Category') | The updated category |

<a name='T-BibALEXapi-Controllers-ChannelsController'></a>
## ChannelsController `type`

##### Namespace

BibALEXapi.Controllers

##### Summary

The Controller associated with the Channels. This controller can only be accessed while authenticated. Authentication occurs via a separate, external authenticator.

<a name='M-BibALEXapi-Controllers-ChannelsController-DeleteChannel-System-Int32-'></a>
### DeleteChannel(id) `method`

##### Summary

Deletes an existing channel

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The unique identifier of the channel to be deleted |

<a name='M-BibALEXapi-Controllers-ChannelsController-GetChannel-System-Int32-'></a>
### GetChannel(id) `method`

##### Summary

Retrieves a specific channel

##### Returns

The Channel whose identifier matches the input

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The unique identifier for the channel to be retrieved |

<a name='M-BibALEXapi-Controllers-ChannelsController-GetChannels'></a>
### GetChannels() `method`

##### Summary

Retrieves all channels.

##### Returns

A list of all channels

##### Parameters

This method has no parameters.

<a name='M-BibALEXapi-Controllers-ChannelsController-PostChannel-BibALEXapi-Models-ChannelDTO-'></a>
### PostChannel(channel) `method`

##### Summary

Inserts a new channel

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| channel | [BibALEXapi.Models.ChannelDTO](Models/ChannelDTO.cs 'BibALEXapi.Models.ChannelDTO') | The channel to be inserted |

<a name='M-BibALEXapi-Controllers-ChannelsController-PutChannel-System-Int32,BibALEXapi-Models-ChannelDTO-'></a>
### PutChannel(id,channel) `method`

##### Summary

Updates an existing channel

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The unique identifier of the channel to be updated |
| channel | [BibALEXapi.Models.ChannelDTO](Models/ChannelDTO.cs 'BibALEXapi.Models.ChannelDTO') | The modified channel |

<a name='T-BibALEXapi-Controllers-PlaylistsController'></a>
## PlaylistsController `type`

##### Namespace

BibALEXapi.Controllers

##### Summary

The controller associated with the Playlists.
Update, Insert and Delete all require authentication. Authentication is provided via an external authenticator.

<a name='M-BibALEXapi-Controllers-PlaylistsController-DeletePlaylist-System-Int32-'></a>
### DeletePlaylist(id) `method`

##### Summary

Deletes an existing playlist.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The unique identifier of the playlist to be deleted. |

<a name='M-BibALEXapi-Controllers-PlaylistsController-GetPlaylist-System-Int32-'></a>
### GetPlaylist(id) `method`

##### Summary

Retrieves a specific playlist

##### Returns

A playlist

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The unique identifier for the playlist |

<a name='M-BibALEXapi-Controllers-PlaylistsController-GetPlaylists-System-Int32-'></a>
### GetPlaylists(chid) `method`

##### Summary

Retrieves all playlists, or all playlists from a given channel

##### Returns

A list of playlists

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| chid | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The unique identifier of the channel from which all playlists are retrieved. Default value is -1 to retrieve all playlists regardless of channel |

<a name='M-BibALEXapi-Controllers-PlaylistsController-PostPlaylist-BibALEXapi-Models-PlaylistDTO-'></a>
### PostPlaylist(playlist) `method`

##### Summary

Inserts a new playlist.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| playlist | [BibALEXapi.Models.PlaylistDTO](Models/PlaylistDTO.cs 'BibALEXapi.Models.PlaylistDTO') | The playlist to be inserted. |

<a name='M-BibALEXapi-Controllers-PlaylistsController-PutPlaylist-System-Int32,BibALEXapi-Models-PlaylistDTO-'></a>
### PutPlaylist(id,playlist) `method`

##### Summary

Updates an existing playlist.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The unique identifier of the playlist to be updated. |
| playlist | [BibALEXapi.Models.PlaylistDTO](Models/PlaylistDTO.cs 'BibALEXapi.Models.PlaylistDTO') | The modified playlist. |

<a name='T-BibALEXapi-Controllers-VideosController'></a>
## VideosController `type`

##### Namespace

BibALEXapi.Controllers

##### Summary

The controller for videos.

<a name='M-BibALEXapi-Controllers-VideosController-DeleteVideo-System-Int32-'></a>
### DeleteVideo(id) `method`

##### Summary

Deletes an existing video object.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The unique identifier of the video object. |

<a name='M-BibALEXapi-Controllers-VideosController-GetVideo-System-Int32-'></a>
### GetVideo(id) `method`

##### Summary

Retrieves a specific video.

##### Returns

A video object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The unique identifier for the video. |

<a name='M-BibALEXapi-Controllers-VideosController-GetVideos-System-Int32,System-Int32,System-Int32-'></a>
### GetVideos(cid,pid,chid) `method`

##### Summary

Retrieves all video objects, or all video objects that meet the input criteria.

##### Returns

A list of videos.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cid | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The unique identifier of a category the retrieved videos are of. |
| pid | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The unique identifier of a playlist the retrieved videos are contained inside. |
| chid | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The unique identifier of a channel the retrieved videos are from. |

<a name='M-BibALEXapi-Controllers-VideosController-PostVideo-BibALEXapi-Models-VideoDTO-'></a>
### PostVideo(video) `method`

##### Summary

Inserts a new video object.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| video | [BibALEXapi.Models.VideoDTO](Models/VideoDTO.cs 'BibALEXapi.Models.VideoDTO') | The video object to be inserted. |

<a name='M-BibALEXapi-Controllers-VideosController-PutVideo-System-Int32,BibALEXapi-Models-VideoDTO-'></a>
### PutVideo(id,video) `method`

##### Summary

Updates an existing video object with a new one.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The unique identifier of the object to be updated. |
| video | [BibALEXapi.Models.VideoDTO](Models/VideoDTO.cs 'BibALEXapi.Models.VideoDTO') | The modified video object. |

<a name='T-BibALEXapi-Controllers-VisibilitiesController'></a>
## VisibilitiesController `type`

##### Namespace

BibALEXapi.Controllers

##### Summary

The controller associated with visibility settings.

<a name='M-BibALEXapi-Controllers-VisibilitiesController-DeleteVisibility-System-Int32-'></a>
### DeleteVisibility(id) `method`

##### Summary

Deletes an existing visibility setting. Requires authentication.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The unique identifier of the visibility setting. |

<a name='M-BibALEXapi-Controllers-VisibilitiesController-GetVisibilities'></a>
### GetVisibilities() `method`

##### Summary

Retrieves all visibility settings.

##### Returns

A list of visibilities.

##### Parameters

This method has no parameters.

<a name='M-BibALEXapi-Controllers-VisibilitiesController-GetVisibility-System-Int32-'></a>
### GetVisibility(id) `method`

##### Summary

Retrieves a specific visibiility setting.

##### Returns

A visibility.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The unique identifier for the visibiilty setting. |

<a name='M-BibALEXapi-Controllers-VisibilitiesController-PostVisibility-BibALEXapi-Models-Visibility-'></a>
### PostVisibility(visibility) `method`

##### Summary

Inserts a new visibility setting. Requires authentication.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| visibility | [BibALEXapi.Models.Visibility](Models/Visibility.cs 'BibALEXapi.Models.Visibility') | The visibility to be inserted. |

<a name='M-BibALEXapi-Controllers-VisibilitiesController-PutVisibility-System-Int32,BibALEXapi-Models-Visibility-'></a>
### PutVisibility(id,visibility) `method`

##### Summary

Updates an existing visibility setting with a new one. Requires authentication.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The unique identifier for the visibiility setting. |
| visibility | [BibALEXapi.Models.Visibility](Models/Visibility.cs 'BibALEXapi.Models.Visibility') | The new visibility setting. |
