# Rider File Templates

Rider file templates for creating directories for new **Game** and **UI** features in **ECS Proto** or **ECS Lite** projects.

---

## What is this?

File Templates in Rider are a powerful tool that can save you time when creating repetitive scripts. They offer extensive functionality, but here we’ll focus on how to use them to create a ready-made directory with the required scripts for your features.

For example, if you have a consistent architectural structure for your features, creating a new one often involves setting up the same folders and files repeatedly. This process can be tedious, but with file templates, you can automate it and make it efficient.

To access File Templates in Rider:

1. Go to `File -> Settings -> Editor -> File Templates -> Other Languages.`



---

## How to Use

Before installing the templates, decide if you want to use them in all Rider projects (**Default Scheme**) or only in a specific project (**Project Scheme**).

### Installing for Default Scheme

1. Download the required template files.
2. Navigate to the directory:
   ```
   ...\Users\"USER"\AppData\Roaming\JetBrains\Rider"VERSION"\fileTemplates
   ```
   > If the `fileTemplates` folder does not exist, create it.
3. Copy the contents of the `Default` folder into this directory.
4. Restart Rider.
5. Open `File -> Settings -> Editor -> File Templates -> Other Languages.`
6. Switch the Scheme to **Default**.

### Installing for Project Scheme

1. Download the required template files.
2. Navigate to the directory:
   ```
   ...\"PROJECT NAME"\.idea\.idea."PROJECT NAME"\.idea\fileTemplates
   ```
   > If the `fileTemplates` folder does not exist, create it.
3. Copy the contents of the `Project` folder into this directory.


4. Restart Rider.
5. Open `File -> Settings -> Editor -> File Templates -> Other Languages.`
6. Switch the Scheme to **Project**.

---

## Folder Structure

To make the installation process straightforward, the repository contains three main folders:

- **ProtoAndLeo**
- **Proto**
- **Leo**

Each of these folders contains two subfolders:

- **Default** → Use this if you want to install the templates globally in Rider.
  - Includes `fileTemplates/` and `options/`.
- **Project** → Use this if you want to install the templates for a specific project.
  - Includes `fileTemplates/` and `file.template.settings.xml`.

To install, simply copy the contents of the appropriate **Default** or **Project** folder and place them in the corresponding directory as described above.

---

## Using the Templates

After setting up the templates and selecting the appropriate Scheme, you can start using the templates:

1. In Rider’s project hierarchy, right-click on the folder where you want to create a new feature.
2. Select **Add**.
3. Choose the required template from the list.
4. Done! Enjoy the efficiency.



---

By following these steps, you’ll streamline the creation of repetitive folders and scripts, saving valuable development time. Happy coding!

