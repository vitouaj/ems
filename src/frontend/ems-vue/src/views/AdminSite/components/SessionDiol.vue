<template>
    <v-dialog max-width="600">
        <template v-slot:activator="{ props: activatorProps }">
            <v-btn v-bind="activatorProps" text="Open Dialog" block>Click to create session</v-btn>
        </template>
      <template v-slot:default="{ isActive }">
        <v-card title="Session Card" style="box-shadow: 2px 5px 1px rgba(255, 127, 0, 0.4);">
          <v-card-item>
            <each-session 
              v-for="(session, index) in sessions" 
              :key="index" 
              :index="index"
              :session="session" 
              @update-session="updateSession(index, $event)" 
            />
            <v-row class="mb-2">
              <v-col class="d-flex justify-center">
                <v-btn icon @click="addSession">+</v-btn>
              </v-col>
            </v-row>
          </v-card-item>
          <v-card-actions class="d-flex justify-end">
            <v-btn variant="elevated" color="#004B8D" @click="isActive.value = false">Close</v-btn>
            <v-btn variant="elevated" color="#FF7F00" @click="saveSessions">Save</v-btn>
          </v-card-actions>
        </v-card>
      </template>
    </v-dialog>
  </template>
  
  <script>
  import EachSession from './EachSession.vue';
  
  export default {
    components: {
      EachSession
    },
    data() {
      return {
        sessions: []
      };
    },
    methods: {
      addSession() {
        this.sessions.push({ 
          id: null,
          title: `Session ${this.sessions.length + 1}`,
          date: null,
          start_time: null,
          end_time: null,
          description: null
        });
      },
      updateSession(index, session) {
        this.$set(this.sessions, index, session);
      },
      saveSessions() {
        this.$emit('update-sessions', this.sessions);
      }
    }
  };
  </script>
  
