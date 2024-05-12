<template>
    <div>
        <span class="font-weight-bold">Menu</span>
        <v-list>
          <v-list-item>
            <router-link to="/admin/dashboard">Dashboard</router-link>
          </v-list-item>
          <v-list-item>
            <router-link to="/admin/create-event">Create Event</router-link>
          </v-list-item>
          <v-list-item>
            <router-link to="/admin/all-events">Your Event</router-link>
          </v-list-item>
        </v-list>
    </div>
</template>

<style scoped>
  *  {
    color: #004B8D;
    text-decoration: none;
  }
</style>