<template>
  <v-container>
    <v-row no-gutter>
      <v-col cols="12" class="d-flex justify-space-between mt-5 align-center">
        <p class="font-weight-bold text-h4">Event<span class="font-weight-bold" style="color: #FF7F00">Hub</span></p>
        <div class="d-flex align-center mt-5">
          <v-badge color="error" content="2" class="px-5">
             <v-icon size="x-large" color="#FF7F00">mdi-email-outline</v-icon>
          </v-badge>
         
          <v-menu
            min-width="200px"
            rounded
          >
            <template v-slot:activator="{ props }">
              <v-btn
                icon
                v-bind="props"
                color="warning"
                size="small"
              >
                <v-avatar
                  color="brown"
                  size="35"
                >
                  <span class="text-h5">{{ user.initials }}</span>
                </v-avatar>
              </v-btn>
            </template>
            <v-card>
              <v-card-text>
                <div class="mx-auto text-center">
                  <v-avatar
                    color="brown"
                  >
                    <span class="text-h5">{{ user.initials }}</span>
                  </v-avatar>
                  <h3>{{ user.fullName }}</h3>
                  <p class="text-caption mt-1">
                    {{ user.email }}
                  </p>
                  <v-divider class="my-3"></v-divider>
                  <v-btn
                    variant="text"
                  >
                    Profile
                  </v-btn>
                  <v-divider class="my-3"></v-divider>
                  <v-btn
                    variant="text"
                  >
                    Log out
                  </v-btn>
                </div>
              </v-card-text>
            </v-card>
          </v-menu>
        </div>
      </v-col>
      <v-col cols="2">
        <drawer-view/>
      </v-col>
      <v-col cols="10">
        <router-view></router-view>
      </v-col>
    </v-row>
  </v-container>
</template>

<script>
import DrawerView from './DrawerView.vue';
  export default {
    components: {
      DrawerView
    },
    data: () => ({
      user: {
        initials: 'JD',
        fullName: 'John Doe',
        email: 'john.doe@doe.com',
      },
    }),
  }
</script>

<style scoped>
  *  {
    color: #004B8D;
    text-decoration: none;
  }
</style>