### Figma
1. View Figma proto type via  [https://shorturl.at/dizW7](https://shorturl.at/dizW7)

### Installation

_Below is how you setup development._

1. Clone the repo
   ```sh
   git clone https://github.com/vitouaj/ems.git

2. For Frontend Dev, the Frontend project located in in "ems-vue" directory.
    ```sh
    cd ems/src/frontend/ems-vue
    ```
3. Then install NPM packages
   ```sh
   npm install
   ```

4. Run project
   ```sh
   npm build
   npm run dev
   ````


### Version 2 Planning


### Backend



1. run docker compose ( to fire database and pgadmin4 )

   go to src

   ```sh
      docker compose up
    ```

2. go to event.api folder, then run 

``` dotnet ef database update ```

3. then run

``` dotnet watch ```

   

1. Change Implementation of Guid to Manageble Id like "E-20239023" from datetime.
