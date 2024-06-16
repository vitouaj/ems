<script setup lang="ts">
import NavigationBar from '@/components/NavigationBar.vue'
</script>

<template>
  <navigation-bar />

  <v-card subtitle="this is the subtitle" text="this is the text of my v-card">
    <v-card-actions>
      <v-btn>View Event</v-btn>
    </v-card-actions>
  </v-card>
</template>
