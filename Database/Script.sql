USE [BackendProject]
GO
SET IDENTITY_INSERT [dbo].[Blogs] ON 

INSERT [dbo].[Blogs] ([Id], [Title], [Content], [CreatedDate], [ImageName]) VALUES (3, N'Take a Look at Hotels for All Budgets', N'Nam nisl lacus, dignissim ac tristique ut, scelerisque eu massa. Vestibulum ligula nunc, rutrum in malesuada vitae, tempus sed augue. Curabitur quis lectus quis augue dapibus facilisis. Vivamus tincidunt orci est, in vehicula nisi eleifend ut. Vestibulum sagittis varius orci vitae.

Mauris aliquet ultricies ante, non faucibus ante gravida sed. Sed ultrices pellentesque purus, vulputate volutpat ipsum hendrerit sed neque sed sapien rutrum.
In ut odio libero, at vulputate urna. Nulla tristique mi a massa convallis cursus. Nulla eu mi magna. Etiam suscipit commodo gravida. Cras suscipit, quam vitae adipiscing faucibus, risus nibh laoreet odio, a porttitor metus eros ut enim. Morbi augue velit, tempus mattis dignissim nec, porta sed risus. Donec eget magna eu lorem tristique pellentesque eget eu dui. Fusce lacinia tempor malesuada. Ut lacus sapien, placerat a ornare nec, elementum sit amet felis. Maecenas pretium lorem hendrerit eros sagittis fermentum.

Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo. In libero urna, venenatis sit amet ornare non, suscipit nec risus. Sed consequat justo non mauris pretium at tempor justo sodales. Quisque tincidunt laoreet malesuada. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Integer vitae ante enim. Fusce sed elit est. Suspendisse sit amet mauris in quam pretium faucibus et aliquam odio.', CAST(N'2022-01-04T18:58:10.7531359' AS DateTime2), N'35ec0b28-c1a1-4559-a79e-5d8e9afd0f63-20220104185810-dp-3.jpg')
INSERT [dbo].[Blogs] ([Id], [Title], [Content], [CreatedDate], [ImageName]) VALUES (4, N'Take a Look at Hotels for All Budgets', N'Nam nisl lacus, dignissim ac tristique ut, scelerisque eu massa. Vestibulum ligula nunc, rutrum in malesuada vitae, tempus sed augue. Curabitur quis lectus quis augue dapibus facilisis. Vivamus tincidunt orci est, in vehicula nisi eleifend ut. Vestibulum sagittis varius orci vitae.

Mauris aliquet ultricies ante, non faucibus ante gravida sed. Sed ultrices pellentesque purus, vulputate volutpat ipsum hendrerit sed neque sed sapien rutrum.
In ut odio libero, at vulputate urna. Nulla tristique mi a massa convallis cursus. Nulla eu mi magna. Etiam suscipit commodo gravida. Cras suscipit, quam vitae adipiscing faucibus, risus nibh laoreet odio, a porttitor metus eros ut enim. Morbi augue velit, tempus mattis dignissim nec, porta sed risus. Donec eget magna eu lorem tristique pellentesque eget eu dui. Fusce lacinia tempor malesuada. Ut lacus sapien, placerat a ornare nec, elementum sit amet felis. Maecenas pretium lorem hendrerit eros sagittis fermentum.

Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo. In libero urna, venenatis sit amet ornare non, suscipit nec risus. Sed consequat justo non mauris pretium at tempor justo sodales. Quisque tincidunt laoreet malesuada. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Integer vitae ante enim. Fusce sed elit est. Suspendisse sit amet mauris in quam pretium faucibus et aliquam odio.', CAST(N'2022-01-04T19:07:38.0433196' AS DateTime2), N'1d889714-27cb-40f0-bf2a-90e66ccf5d05-20220104190738-dp-4.jpg')
INSERT [dbo].[Blogs] ([Id], [Title], [Content], [CreatedDate], [ImageName]) VALUES (5, N'Take a Look at Hotels for All Budgets', N'Nam nisl lacus, dignissim ac tristique ut, scelerisque eu massa. Vestibulum ligula nunc, rutrum in malesuada vitae, tempus sed augue. Curabitur quis lectus quis augue dapibus facilisis. Vivamus tincidunt orci est, in vehicula nisi eleifend ut. Vestibulum sagittis varius orci vitae.

Mauris aliquet ultricies ante, non faucibus ante gravida sed. Sed ultrices pellentesque purus, vulputate volutpat ipsum hendrerit sed neque sed sapien rutrum.
In ut odio libero, at vulputate urna. Nulla tristique mi a massa convallis cursus. Nulla eu mi magna. Etiam suscipit commodo gravida. Cras suscipit, quam vitae adipiscing faucibus, risus nibh laoreet odio, a porttitor metus eros ut enim. Morbi augue velit, tempus mattis dignissim nec, porta sed risus. Donec eget magna eu lorem tristique pellentesque eget eu dui. Fusce lacinia tempor malesuada. Ut lacus sapien, placerat a ornare nec, elementum sit amet felis. Maecenas pretium lorem hendrerit eros sagittis fermentum.

Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo. In libero urna, venenatis sit amet ornare non, suscipit nec risus. Sed consequat justo non mauris pretium at tempor justo sodales. Quisque tincidunt laoreet malesuada. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Integer vitae ante enim. Fusce sed elit est. Suspendisse sit amet mauris in quam pretium faucibus et aliquam odio.', CAST(N'2022-01-04T19:08:03.2778624' AS DateTime2), N'2bebbd4b-b20f-427f-893a-682625288d27-20220104190803-dp-2.jpg')
SET IDENTITY_INSERT [dbo].[Blogs] OFF
SET IDENTITY_INSERT [dbo].[Comments] ON 

INSERT [dbo].[Comments] ([Id], [CommenterName], [Email], [Subject], [Content], [BlogId]) VALUES (13, NULL, NULL, NULL, NULL, 3)
INSERT [dbo].[Comments] ([Id], [CommenterName], [Email], [Subject], [Content], [BlogId]) VALUES (14, NULL, NULL, NULL, NULL, 3)
SET IDENTITY_INSERT [dbo].[Comments] OFF
SET IDENTITY_INSERT [dbo].[Features] ON 

INSERT [dbo].[Features] ([Id], [Name]) VALUES (3, N'Swimming Pool')
INSERT [dbo].[Features] ([Id], [Name]) VALUES (4, N'FREE WIFI INTERNET ACCESS INCLUDED')
INSERT [dbo].[Features] ([Id], [Name]) VALUES (5, N'Free Parking')
INSERT [dbo].[Features] ([Id], [Name]) VALUES (6, N'SwimmingPool Outdoor')
INSERT [dbo].[Features] ([Id], [Name]) VALUES (7, N'Family ROOMS')
INSERT [dbo].[Features] ([Id], [Name]) VALUES (8, N'nON sMOKING rooms')
SET IDENTITY_INSERT [dbo].[Features] OFF
SET IDENTITY_INSERT [dbo].[Restaurants] ON 

INSERT [dbo].[Restaurants] ([Id], [Name], [Address], [ProfilPictureName], [CoverImageName], [Type], [Status], [Location], [About], [Phone1], [Phone2], [Phone3], [DirectorName], [DirectorPhone], [DirectorMail], [DirectorWebsite], [Capacity]) VALUES (8, N'Tom House', N'12345 Little Lonsdale St, Melbourne', N'e50c968b-0274-4b1a-8bdf-9ed975c64116-20220105005800-logo-1.png', N'c41ccb9f-8c66-49b2-87c7-35fd1787080f-20220105005800-most-img-1.jpg', N'EAT & DRINK', N'NOW OPEN', N'Cosby sweater eu banh mi, qui irure terry richardson ex squid. Aliquip placeat salvia cillum iphone. Seitan aliquip quis cardigan american apparel, butcher voluptate nisi qui.', N'Lorem ipsum dolor sit amet consectetur adipisicing elit. Placeat rerum doloribus repudiandae nulla odit, omnis ex, a assumenda fugiat quasi neque necessitatibus fugit maiores quis. Quo dolor minus pariatur natus!

Lorem ipsum dolor sit amet consectetur adipisicing elit. Placeat rerum doloribus repudiandae nulla odit, omnis ex, a assumenda fugiat quasi neque necessitatibus fugit maiores quis. Quo dolor minus pariatur natus! Lorem ipsum dolor sit amet consectetur adipisicing elit. Blanditiis quis laudantium est pariatur, harum laboriosam odit delectus vitae minima dolorem ipsam repudiandae sunt non. Dolorem adipisci voluptates doloribus voluptatum nihil.', N'+123 123 456 45', N'+123 123 456 45', N'+123 123 456 45', N'Victoria Benson', N'(123) 123-456', N'victoria@victoria.com', N'http://example.com', 15)
INSERT [dbo].[Restaurants] ([Id], [Name], [Address], [ProfilPictureName], [CoverImageName], [Type], [Status], [Location], [About], [Phone1], [Phone2], [Phone3], [DirectorName], [DirectorPhone], [DirectorMail], [DirectorWebsite], [Capacity]) VALUES (9, N'Burger House', N'4340 Cambridge Court Natural Dam, Arkansas', N'1bea5148-7c00-47ac-961a-a5600a5c8bae-20220105005829-logo-2.png', N'416453d3-081e-444f-9492-5e0e0cc9c491-20220105005829-most-img-2.jpg', N'EAT & DRINK', N'NOW OPEN', N'Cosby sweater eu banh mi, qui irure terry richardson ex squid. Aliquip placeat salvia cillum iphone. Seitan aliquip quis cardigan american apparel, butcher voluptate nisi qui.', N'Lorem ipsum dolor sit amet consectetur adipisicing elit. Placeat rerum doloribus repudiandae nulla odit, omnis ex, a assumenda fugiat quasi neque necessitatibus fugit maiores quis. Quo dolor minus pariatur natus!

Lorem ipsum dolor sit amet consectetur adipisicing elit. Placeat rerum doloribus repudiandae nulla odit, omnis ex, a assumenda fugiat quasi neque necessitatibus fugit maiores quis. Quo dolor minus pariatur natus! Lorem ipsum dolor sit amet consectetur adipisicing elit. Blanditiis quis laudantium est pariatur, harum laboriosam odit delectus vitae minima dolorem ipsam repudiandae sunt non. Dolorem adipisci voluptates doloribus voluptatum nihil.', N'+123 123 456 45', N'+123 123 456 45', N'+123 123 456 45', N'Victoria Benson', N'(123) 123-456', N'victoria@victoria.com', N'http://example.com', 5)
INSERT [dbo].[Restaurants] ([Id], [Name], [Address], [ProfilPictureName], [CoverImageName], [Type], [Status], [Location], [About], [Phone1], [Phone2], [Phone3], [DirectorName], [DirectorPhone], [DirectorMail], [DirectorWebsite], [Capacity]) VALUES (10, N'Hotel Govendor', N'2924 Elliott Street, Nashua New Hampshire', N'c6c324a2-f970-48b6-9081-97c004ad845f-20220104183742-logo-3.png', N'7c8c0bb0-0dbb-4d88-add9-5bf6d871fcc0-20220104183742-most-img-3.jpg', N'CONCERT', N'Coming Soon', N'Cosby sweater eu banh mi, qui irure terry richardson ex squid. Aliquip placeat salvia cillum iphone. Seitan aliquip quis cardigan american apparel, butcher voluptate nisi qui.', N'Lorem ipsum dolor sit amet consectetur adipisicing elit. Placeat rerum doloribus repudiandae nulla odit, omnis ex, a assumenda fugiat quasi neque necessitatibus fugit maiores quis. Quo dolor minus pariatur natus!

Lorem ipsum dolor sit amet consectetur adipisicing elit. Placeat rerum doloribus repudiandae nulla odit, omnis ex, a assumenda fugiat quasi neque necessitatibus fugit maiores quis. Quo dolor minus pariatur natus! Lorem ipsum dolor sit amet consectetur adipisicing elit. Blanditiis quis laudantium est pariatur, harum laboriosam odit delectus vitae minima dolorem ipsam repudiandae sunt non. Dolorem adipisci voluptates doloribus voluptatum nihil.', N'+123 123 456 45', N'+123 123 456 45', N'+123 123 456 45', N'Victoria Benson', N'(123) 123-456', N'victoria@victoria.com', N'http://example.com', 0)
SET IDENTITY_INSERT [dbo].[Restaurants] OFF
SET IDENTITY_INSERT [dbo].[RestaurantToFeatures] ON 

INSERT [dbo].[RestaurantToFeatures] ([Id], [RestaurantId], [FeatureId]) VALUES (29, 10, 3)
INSERT [dbo].[RestaurantToFeatures] ([Id], [RestaurantId], [FeatureId]) VALUES (30, 10, 4)
INSERT [dbo].[RestaurantToFeatures] ([Id], [RestaurantId], [FeatureId]) VALUES (31, 10, 5)
INSERT [dbo].[RestaurantToFeatures] ([Id], [RestaurantId], [FeatureId]) VALUES (32, 10, 6)
INSERT [dbo].[RestaurantToFeatures] ([Id], [RestaurantId], [FeatureId]) VALUES (33, 10, 7)
INSERT [dbo].[RestaurantToFeatures] ([Id], [RestaurantId], [FeatureId]) VALUES (34, 10, 8)
INSERT [dbo].[RestaurantToFeatures] ([Id], [RestaurantId], [FeatureId]) VALUES (62, 8, 3)
INSERT [dbo].[RestaurantToFeatures] ([Id], [RestaurantId], [FeatureId]) VALUES (63, 8, 4)
INSERT [dbo].[RestaurantToFeatures] ([Id], [RestaurantId], [FeatureId]) VALUES (64, 8, 5)
INSERT [dbo].[RestaurantToFeatures] ([Id], [RestaurantId], [FeatureId]) VALUES (65, 8, 6)
INSERT [dbo].[RestaurantToFeatures] ([Id], [RestaurantId], [FeatureId]) VALUES (66, 8, 7)
INSERT [dbo].[RestaurantToFeatures] ([Id], [RestaurantId], [FeatureId]) VALUES (67, 8, 8)
INSERT [dbo].[RestaurantToFeatures] ([Id], [RestaurantId], [FeatureId]) VALUES (68, 9, 3)
INSERT [dbo].[RestaurantToFeatures] ([Id], [RestaurantId], [FeatureId]) VALUES (69, 9, 4)
INSERT [dbo].[RestaurantToFeatures] ([Id], [RestaurantId], [FeatureId]) VALUES (70, 9, 5)
INSERT [dbo].[RestaurantToFeatures] ([Id], [RestaurantId], [FeatureId]) VALUES (71, 9, 6)
INSERT [dbo].[RestaurantToFeatures] ([Id], [RestaurantId], [FeatureId]) VALUES (72, 9, 7)
INSERT [dbo].[RestaurantToFeatures] ([Id], [RestaurantId], [FeatureId]) VALUES (73, 9, 8)
SET IDENTITY_INSERT [dbo].[RestaurantToFeatures] OFF
SET IDENTITY_INSERT [dbo].[Bookings] ON 

INSERT [dbo].[Bookings] ([Id], [BookingDate], [ClientName], [RestaurantId]) VALUES (1, CAST(N'2022-01-11T13:30:00.0000000' AS DateTime2), N'weqweqeq', 8)
SET IDENTITY_INSERT [dbo].[Bookings] OFF
SET IDENTITY_INSERT [dbo].[Menus] ON 

INSERT [dbo].[Menus] ([Id], [Name], [Price], [Ingredients], [RestaurantId]) VALUES (1, N'Classic Burger', 6, N'Beef, salad, mayonnaise, spicey relish, cheese', 8)
INSERT [dbo].[Menus] ([Id], [Name], [Price], [Ingredients], [RestaurantId]) VALUES (2, N'Cheddar Burger', 6, N'Cheddar cheese, lettuce, tomato, onion, dill pickles', 8)
INSERT [dbo].[Menus] ([Id], [Name], [Price], [Ingredients], [RestaurantId]) VALUES (3, N'Veggie Burger', 6, N'Panko crumbed and fried, grilled peppers and mushroom', 8)
INSERT [dbo].[Menus] ([Id], [Name], [Price], [Ingredients], [RestaurantId]) VALUES (4, N'Chicken Burger', 6, N'Cheese, chicken fillet, avocado, bacon, tomatoes, basil', 8)
INSERT [dbo].[Menus] ([Id], [Name], [Price], [Ingredients], [RestaurantId]) VALUES (5, N'Classic Burger', 6, N'Beef, salad, mayonnaise, spicey relish, cheese', 9)
INSERT [dbo].[Menus] ([Id], [Name], [Price], [Ingredients], [RestaurantId]) VALUES (6, N'Cheddar Burger', 6, N'Cheddar cheese, lettuce, tomato, onion, dill pickles', 9)
INSERT [dbo].[Menus] ([Id], [Name], [Price], [Ingredients], [RestaurantId]) VALUES (7, N'Veggie Burger', 6, N'Panko crumbed and fried, grilled peppers and mushroom', 9)
INSERT [dbo].[Menus] ([Id], [Name], [Price], [Ingredients], [RestaurantId]) VALUES (8, N'Chicken Burger', 6, N'Cheese, chicken fillet, avocado, bacon, tomatoes, basil', 9)
INSERT [dbo].[Menus] ([Id], [Name], [Price], [Ingredients], [RestaurantId]) VALUES (9, N'Classic Burger', 6, N'Beef, salad, mayonnaise, spicey relish, cheese', 10)
INSERT [dbo].[Menus] ([Id], [Name], [Price], [Ingredients], [RestaurantId]) VALUES (10, N'Cheddar Burger', 6, N'Cheddar cheese, lettuce, tomato, onion, dill pickles', 10)
INSERT [dbo].[Menus] ([Id], [Name], [Price], [Ingredients], [RestaurantId]) VALUES (11, N'Veggie Burger', 6, N'Panko crumbed and fried, grilled peppers and mushroom', 10)
INSERT [dbo].[Menus] ([Id], [Name], [Price], [Ingredients], [RestaurantId]) VALUES (12, N'Chicken Burger', 6, N'Cheese, chicken fillet, avocado, bacon, tomatoes, basil', 10)
SET IDENTITY_INSERT [dbo].[Menus] OFF
SET IDENTITY_INSERT [dbo].[Reviews] ON 

INSERT [dbo].[Reviews] ([Id], [FullName], [CreatedDate], [Content], [RestaurantId]) VALUES (12, N'dsaasdasd', CAST(N'2022-01-05T13:52:53.9044506' AS DateTime2), N'sdfsdfs', 8)
INSERT [dbo].[Reviews] ([Id], [FullName], [CreatedDate], [Content], [RestaurantId]) VALUES (13, N'dsaasdasd', CAST(N'2022-01-05T13:53:46.3768555' AS DateTime2), N'sdfsdfs', 8)
SET IDENTITY_INSERT [dbo].[Reviews] OFF
SET IDENTITY_INSERT [dbo].[Contacts] ON 

INSERT [dbo].[Contacts] ([Id], [FirstName], [LastName], [Email], [Subject], [Message]) VALUES (1, N'ewfewfsdf', N'sdfsfsfsdf', N'office@example.com', N'Internship', NULL)
SET IDENTITY_INSERT [dbo].[Contacts] OFF
SET IDENTITY_INSERT [dbo].[CustomUsers] ON 

INSERT [dbo].[CustomUsers] ([Id], [MyUsername], [Password]) VALUES (1, N'Shahin', N'Sahin12345')
SET IDENTITY_INSERT [dbo].[CustomUsers] OFF
SET IDENTITY_INSERT [dbo].[Settings] ON 

INSERT [dbo].[Settings] ([Id], [LogoName], [Email], [Phone], [Address], [BannerImageName]) VALUES (2, N'2de44666-30eb-4b5b-9446-2144dacbc8f4-20220103224459-logo.png', N'office@example.com', N'(123) 123-456', N'12345 Little Lonsdale St, Melbourne', N'f08af728-8c55-44ed-be72-6fdc2bd4ebe9-20220103224459-banner.jpg')
SET IDENTITY_INSERT [dbo].[Settings] OFF
SET IDENTITY_INSERT [dbo].[Socials] ON 

INSERT [dbo].[Socials] ([Id], [Name], [Icon], [Link]) VALUES (1, N'Twitter', N'fa fa-twitter', N'https://twitter.com/')
INSERT [dbo].[Socials] ([Id], [Name], [Icon], [Link]) VALUES (2, N'Facebook', N'fa fa-facebook-square', N'https://www.facebook.com/')
INSERT [dbo].[Socials] ([Id], [Name], [Icon], [Link]) VALUES (3, N'Dribble', N'fa fa-dribbble', N'https://dribbble.com/')
INSERT [dbo].[Socials] ([Id], [Name], [Icon], [Link]) VALUES (4, N'Github', N'fa fa-github', N'https://github.com/')
SET IDENTITY_INSERT [dbo].[Socials] OFF
