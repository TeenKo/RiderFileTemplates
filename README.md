# Rider File Templates

Rider file templates for creating directories for new **Game** and **UI** features in **ECS Proto** or **ECS Lite** projects.

---

## What is this?
File Templates in Rider are a powerful tool that can save you time when creating repetitive scripts. They offer extensive functionality, but here we’ll focus on how to use them to create a ready-made directory with the required scripts for your features.

For example, if you have a consistent architectural structure for your features, creating a new one often involves setting up the same folders and files repeatedly. This process can be tedious, but with file templates, you can automate it and make it efficient.

To access File Templates in Rider:
1. Go to `File -> Settings -> Editor -> File Templates -> Other Languages.`

![Settings screenshot](https://github.com/user-attachments/assets/3a3b6bfc-cdf6-48c5-ad82-4a884e0440be)

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
3. Copy the downloaded files into the `fileTemplates` folder.
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
3. Copy the downloaded files into the `fileTemplates` folder.
4. Restart Rider.
5. Open `File -> Settings -> Editor -> File Templates -> Other Languages.`
6. Switch the Scheme to **Project**.

---

## Using the Templates
After setting up the templates and selecting the appropriate Scheme, you can start using the templates:
1. In Rider’s project hierarchy, right-click on the folder where you want to create a new feature.
2. Select **Add**.
3. Choose the required template from the list.
4. Done! Enjoy the efficiency.

![Template usage screenshot](https://github.com/user-attachments/assets/8d865da6-6c01-4058-8dc8-5036f804a9d5)

---

By following these steps, you’ll streamline the creation of repetitive folders and scripts, saving valuable development time. Happy coding!
