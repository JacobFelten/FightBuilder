IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191130055728_Initial')
BEGIN
    CREATE TABLE [Equipment] (
        [EquipmentID] int NOT NULL IDENTITY,
        [Type] nvarchar(max) NULL,
        [Name] nvarchar(max) NOT NULL,
        [Description] nvarchar(max) NULL,
        [Color] nvarchar(max) NULL,
        [PhysDam] int NOT NULL,
        [MagDam] int NOT NULL,
        [FireDam] int NOT NULL,
        [PhysDef] int NOT NULL,
        [MagDef] int NOT NULL,
        [FireDef] int NOT NULL,
        CONSTRAINT [PK_Equipment] PRIMARY KEY ([EquipmentID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191130055728_Initial')
BEGIN
    CREATE TABLE [Fighters] (
        [FighterID] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NOT NULL,
        [Description] nvarchar(max) NULL,
        [Color] nvarchar(max) NULL,
        [HeadEquipmentID] int NULL,
        [ChestEquipmentID] int NULL,
        [GlovesEquipmentID] int NULL,
        [PantsEquipmentID] int NULL,
        [ShoesEquipmentID] int NULL,
        [RingEquipmentID] int NULL,
        [RightHandEquipmentID] int NULL,
        [LeftHandEquipmentID] int NULL,
        [Wins] int NOT NULL,
        [Losses] int NOT NULL,
        CONSTRAINT [PK_Fighters] PRIMARY KEY ([FighterID]),
        CONSTRAINT [FK_Fighters_Equipment_ChestEquipmentID] FOREIGN KEY ([ChestEquipmentID]) REFERENCES [Equipment] ([EquipmentID]) ON DELETE NO ACTION,
        CONSTRAINT [FK_Fighters_Equipment_GlovesEquipmentID] FOREIGN KEY ([GlovesEquipmentID]) REFERENCES [Equipment] ([EquipmentID]) ON DELETE NO ACTION,
        CONSTRAINT [FK_Fighters_Equipment_HeadEquipmentID] FOREIGN KEY ([HeadEquipmentID]) REFERENCES [Equipment] ([EquipmentID]) ON DELETE NO ACTION,
        CONSTRAINT [FK_Fighters_Equipment_LeftHandEquipmentID] FOREIGN KEY ([LeftHandEquipmentID]) REFERENCES [Equipment] ([EquipmentID]) ON DELETE NO ACTION,
        CONSTRAINT [FK_Fighters_Equipment_PantsEquipmentID] FOREIGN KEY ([PantsEquipmentID]) REFERENCES [Equipment] ([EquipmentID]) ON DELETE NO ACTION,
        CONSTRAINT [FK_Fighters_Equipment_RightHandEquipmentID] FOREIGN KEY ([RightHandEquipmentID]) REFERENCES [Equipment] ([EquipmentID]) ON DELETE NO ACTION,
        CONSTRAINT [FK_Fighters_Equipment_RingEquipmentID] FOREIGN KEY ([RingEquipmentID]) REFERENCES [Equipment] ([EquipmentID]) ON DELETE NO ACTION,
        CONSTRAINT [FK_Fighters_Equipment_ShoesEquipmentID] FOREIGN KEY ([ShoesEquipmentID]) REFERENCES [Equipment] ([EquipmentID]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191130055728_Initial')
BEGIN
    CREATE INDEX [IX_Fighters_ChestEquipmentID] ON [Fighters] ([ChestEquipmentID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191130055728_Initial')
BEGIN
    CREATE INDEX [IX_Fighters_GlovesEquipmentID] ON [Fighters] ([GlovesEquipmentID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191130055728_Initial')
BEGIN
    CREATE INDEX [IX_Fighters_HeadEquipmentID] ON [Fighters] ([HeadEquipmentID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191130055728_Initial')
BEGIN
    CREATE INDEX [IX_Fighters_LeftHandEquipmentID] ON [Fighters] ([LeftHandEquipmentID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191130055728_Initial')
BEGIN
    CREATE INDEX [IX_Fighters_PantsEquipmentID] ON [Fighters] ([PantsEquipmentID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191130055728_Initial')
BEGIN
    CREATE INDEX [IX_Fighters_RightHandEquipmentID] ON [Fighters] ([RightHandEquipmentID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191130055728_Initial')
BEGIN
    CREATE INDEX [IX_Fighters_RingEquipmentID] ON [Fighters] ([RingEquipmentID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191130055728_Initial')
BEGIN
    CREATE INDEX [IX_Fighters_ShoesEquipmentID] ON [Fighters] ([ShoesEquipmentID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191130055728_Initial')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20191130055728_Initial', N'2.2.6-servicing-10079');
END;

GO

