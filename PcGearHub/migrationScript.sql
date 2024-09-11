START TRANSACTION;

ALTER TABLE "UpdateDB"."Products" ADD "Image" text;

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20240911113141_Added_Image_Column_to_Product', '8.0.4');

COMMIT;

